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
        public string? FirstName { get; private set; } // Add this line

        public event Action? OnChange;

        public async Task LoadStateAsync()
        {
            var bankIdResult = await _sessionStorage.GetAsync<int?>("SelectedBankId");
            var bankNameResult = await _sessionStorage.GetAsync<string>("SelectedBankName");
            var firstNameResult = await _sessionStorage.GetAsync<string>("FirstName"); // Add this line

            SelectedBankId = bankIdResult.Success ? bankIdResult.Value : null;
            SelectedBankName = bankNameResult.Success ? bankNameResult.Value : null;
            FirstName = firstNameResult.Success ? firstNameResult.Value : null; // Add this line

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
                await _sessionStorage.DeleteAsync("SelectedBankId"); // Clear if null
            }

            if (!string.IsNullOrEmpty(bankName))
            {
                await _sessionStorage.SetAsync("SelectedBankName", bankName);
            }
            else
            {
                await _sessionStorage.DeleteAsync("SelectedBankName"); // Clear if empty
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
                await _sessionStorage.DeleteAsync("FirstName"); // Clear if empty
            }
            NotifyStateChanged();
        }

        public async Task<string?> GetFirstName()
        {
            var firstNameResult = await _sessionStorage.GetAsync<string>("FirstName");
            return firstNameResult.Success ? firstNameResult.Value : null;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
