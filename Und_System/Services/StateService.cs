using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Und_System.Services
{
    public class StateService
    {
        private readonly ProtectedSessionStorage _sessionStorage;

        public StateService(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public int? SelectedBankId { get; private set; }
        public string? SelectedBankName { get; private set; }
        public string? FirstName { get; private set; }

        public string? LastName { get; private set; }

        public string? Dept { get; private set; }

        public event Action? OnChange;

        public async Task LoadStateAsync()
        {
            var bankIdResult = await _sessionStorage.GetAsync<int?>("SelectedBankId");
            var bankNameResult = await _sessionStorage.GetAsync<string>("SelectedBankName");
            var firstNameResult = await _sessionStorage.GetAsync<string>("FirstName");
            var lastNameResult = await _sessionStorage.GetAsync<string>("LastName");
            var deptResult = await _sessionStorage.GetAsync<string>("Dept");

            SelectedBankId = bankIdResult.Success ? bankIdResult.Value : null;
            SelectedBankName = bankNameResult.Success ? bankNameResult.Value : null;
            FirstName = firstNameResult.Success ? firstNameResult.Value : null;
            LastName = lastNameResult.Success ? lastNameResult.Value : null;
            Dept = deptResult.Success ? deptResult.Value : null;

            NotifyStateChanged();
        }

        public async Task SetSelectedBank(int? bankId, string bankName)
        {
            SelectedBankId = bankId;
            SelectedBankName = bankName;

            if (bankId.HasValue)
            {
                await _sessionStorage.SetAsync("SelectedBankId", bankId.Value);
            }
            else
            {
                await _sessionStorage.DeleteAsync("SelectedBankId");
            }

            if (!string.IsNullOrEmpty(bankName))
            {
                await _sessionStorage.SetAsync("SelectedBankName", bankName);
            }
            else
            {
                await _sessionStorage.DeleteAsync("SelectedBankName");
            }

            NotifyStateChanged();
        }

        public async Task SetFirstName(string firstName)
        {
            FirstName = firstName;
            if (!string.IsNullOrEmpty(firstName))
            {
                await _sessionStorage.SetAsync("FirstName", firstName);
            }
            else
            {
                await _sessionStorage.DeleteAsync("FirstName");
            }
            NotifyStateChanged();
        }

        public async Task SetLastName(string lastName)
        {
            LastName = lastName;
            if (!string.IsNullOrEmpty(lastName))
            {
                await _sessionStorage.SetAsync("LastName", lastName);
            }
            else
            {
                await _sessionStorage.DeleteAsync("LastName");
            }
            NotifyStateChanged();
        }
        public async Task SetDept(string department)
        {
            Dept = department;
            if (!string.IsNullOrEmpty(department))
            {
                await _sessionStorage.SetAsync("Dept", department);
            }
            else
            {
                await _sessionStorage.DeleteAsync("Dept");
            }
            NotifyStateChanged();
        }

        public async Task<string?> GetFirstName()
        {
            var firstNameResult = await _sessionStorage.GetAsync<string>("FirstName");
            return firstNameResult.Success ? firstNameResult.Value : null;
        }

        public async Task<string?> GetLastName()
        {
            var lastNameResult = await _sessionStorage.GetAsync<string>("LastName");
            return lastNameResult.Success ? lastNameResult.Value : null;
        }
        public async Task<string?> GetDepartment()
        {
            var deptResult = await _sessionStorage.GetAsync<string>("Dept");
            return deptResult.Success ? deptResult.Value : null;
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
