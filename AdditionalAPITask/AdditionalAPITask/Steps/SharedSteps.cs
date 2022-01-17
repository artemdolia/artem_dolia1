using AdditionalAPITask.Managers;
using AdditionalAPITask.Steps;
using RestSharp;
using System.Threading.Tasks;

namespace AdditionalAPITask
{
    public class SharedSteps : HTTPSteps
    {
        public async Task<RestResponse> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, LinkConstants.GetEmployeeUrl);
            return await this.GetAsync(resource);
        }
        public async Task<RestResponse> GetEmployeeByIdAsync()
        {
            var resource = string.Join(this.BaseUrl, LinkConstants.GetEmployeeByIdUrl);
            return await this.GetAsync(resource);
        }
        public async Task<RestResponse> PostEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, LinkConstants.PostEmployeeUrl);
            return await this.PostAsync(resource);
        }
        public async Task<RestResponse> DeleteEmployee()
        {
            var resource = string.Join(this.BaseUrl, LinkConstants.DeleteEmployeeUrl);
            return await this.DeleteAsync(resource);
        }
        public async Task<RestResponse> PutEmployeeAsync(Model.EmployeeModel.Data body)
        {
            var resource = string.Join(this.BaseUrl, LinkConstants.PutEmployeeUrl);
            return await this.PutAsync(resource);
        }
        public async Task<RestResponse> GetNonExistentEmployeeAsync()
        {
            var resource = string.Join(BaseUrl, LinkConstants.GetNonExistentEmployeeUrl);
            return await this.GetAsync(resource);
        }
    }
}
