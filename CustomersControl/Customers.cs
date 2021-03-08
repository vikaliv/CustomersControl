using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersControl
{
    public partial class Customers : Form
    {
        //should be in config file
        private const string URL = "http://localhost:5000/";

        public Customers()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => this.GetCustomers()).ContinueWith(t => this.setCustomers(t.Result));
                //Task.Factory.StartNew<List<DtoCustomer>>(
                // () => this.LoadCustomers(),
                //    CancellationToken.None,
                //    TaskCreationOptions.None,
                //    TaskScheduler.Default)
                // .ContinueWith(x => this.setCustomers(x.Result),
                //    CancellationToken.None,
                //    TaskContinuationOptions.OnlyOnRanToCompletion,
                //    TaskScheduler.Current);
                ////var customers = Task.Run(() => this.GetCustomers().Result).Result;
                //////taskCustomers.Wait();
                ////this.setCustomers(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCustomers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("You should choose the row customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = (int)this.dgvCustomers.SelectedRows[0].Cells["customernumber"].Value;

                Task.Run(() => this.GetCustomerOrders(id));

                //List<DtoOrder> orders = this.GetCustomerOrders(id).Result;

                //var source = new BindingSource();
                //source.DataSource = orders;

                //this.dgvOrders.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)this.dgvCustomers.SelectedRows[0].Cells["customernumber"].Value;

                bool result = Task.Run(() => this.UpdateCustomer((DtoCustomer)this.dgvCustomers.SelectedRows[0].DataBoundItem)).Result;
                //bool result = this.UpdateCustomer((DtoCustomer)this.dgvCustomers.SelectedRows[0].DataBoundItem).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetRiskCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => this.GetRiskCustomers(this.numPercent.Value)).ContinueWith(t => this.setCustomers(t.Result));

                //List<DtoCustomer> customers = this.GetRiskCustomers(this.numPercent.Value).Result;

                //this.setCustomers(customers);
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        #endregion

        #region Private Methods

        private void setCustomers(List<DtoCustomer> customers)
        {
            var source = new BindingSource();
            source.DataSource = customers;

            if (!this.dgvCustomers.InvokeRequired)
            {
                this.dgvCustomers.DataSource = source;

            }
            else
            {
                this.dgvCustomers.Invoke((Action)(() => this.dgvCustomers.DataSource = source));
            }                
        }

        private async Task<List<DtoCustomer>> GetCustomers()
        {
            List<DtoCustomer> results = null;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                httpClient.BaseAddress = new Uri(URL + "api/customer/");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Task.FromResult(httpClient.GetAsync("getall").Result);

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    results = await response.Content.ReadAsAsync<List<DtoCustomer>>();
                }
            }

            return results;
        }

        private async Task GetCustomerOrders(int id)
        {
            //List<DtoOrder> results = null;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                httpClient.BaseAddress = new Uri(URL + "api/customer/");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Task.FromResult(httpClient.GetAsync(id.ToString()).Result);

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    await response.Content.ReadAsAsync<List<DtoOrder>>().ContinueWith(t =>
                        {
                            var source = new BindingSource();
                            source.DataSource = t.Result;

                            if (!this.dgvOrders.InvokeRequired)
                            {
                                this.dgvOrders.DataSource = source;

                            }
                            else
                            {
                                this.dgvOrders.Invoke((Action)(() => this.dgvOrders.DataSource = source));
                            }
                        });
                }
            }
        }

        private async Task<bool> UpdateCustomer(DtoCustomer customer)
        {
            bool result = false;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                httpClient.BaseAddress = new Uri(URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Task.FromResult(httpClient.PutAsJsonAsync("api/customer", customer).Result);

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<bool>();
                }
            }

            return result;
        }

        private async Task<List<DtoCustomer>> GetRiskCustomers(decimal numPercent)
        {
            List<DtoCustomer> results = null;

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                httpClient.BaseAddress = new Uri(URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Task.FromResult(httpClient.GetAsync("api/customer/getriskcustomers/" + numPercent.ToString()).Result);

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    results = await response.Content.ReadAsAsync<List<DtoCustomer>>();
                }
            }

            return results;
        }
    }

    #endregion
}
