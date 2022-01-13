using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class EmployeeController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employee/1";
        private const string PostEmployeeUrl = "/create";
        private const string DeleteEmployeeUrl = "/delete/2";
        private const string PutEmployeeUrl = "/update/2";
        private const string GetNonExistentEmployeeUrl = "/employee/140";

        protected async Task<IRestResponse> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeUrl);
            return await this.GetAsync(resource);
        }
        protected async Task<IRestResponse> GetEmployeeByIdAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeByIdUrl);
            return await this.GetAsync(resource);
        }
        protected async Task<IRestResponse> PostEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, PostEmployeeUrl);
            return await this.PostAsync(resource);
        }
        protected async Task<IRestResponse> DeleteEmployee()
        {
            var resource = string.Join(this.BaseUrl, DeleteEmployeeUrl);
            return await this.DeleteAsync(resource);
        }
        protected async Task<IRestResponse> PutEmployeeAsync(Models.Data body)
        {
            var resource = string.Join(this.BaseUrl, PutEmployeeUrl);
            return await this.PutAsync(resource);
        }
        protected async Task<IRestResponse> GetNonExistentEmployeeAsync()
        {
            var resource = string.Join(BaseUrl, GetNonExistentEmployeeUrl);
            return await this.GetAsync(resource);
        }
    }
}
