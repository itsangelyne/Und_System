using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Und_System.Services
{
    public class StateService(ProtectedSessionStorage sessionStorage)
    {
        private readonly ProtectedSessionStorage _sessionStorage = sessionStorage;
        public int? SelectedBankId { get; private set; }
        public string? SelectedBankName { get; private set; }
        public event Action? OnChange;

        public async Task LoadStateAsync()
        {
            var bankIdResult = await _sessionStorage.GetAsync<int?>("SelectedBankId");
            var bankNameResult = await _sessionStorage.GetAsync<string>("SelectedBankName");

            SelectedBankId = bankIdResult.Success ? bankIdResult.Value : null;
            SelectedBankName = bankNameResult.Success ? bankNameResult.Value : null;

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

            if (!string.IsNullOrEmpty(bankName))
            {
                await _sessionStorage.SetAsync("SelectedBankName", bankName);
            }

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

using System.Threading.Tasks;

namespace Und_System.Services
{
    public class StateService
    {
        private string _firstName;
        private int _selectedBankId;
        private string _selectedBankName;

        public event Action OnChange;

        public async Task SetFirstName(string firstName)
        {
            _firstName = firstName;
            NotifyStateChanged();
            await Task.CompletedTask;
        }

        public async Task<string> GetFirstName()
        {
            return await Task.FromResult(_firstName);
        }

        public async Task SetSelectedBank(int bankId, string bankName)
        {
            _selectedBankId = bankId;
            _selectedBankName = bankName;
            NotifyStateChanged();
            await Task.CompletedTask;
        }

        public int GetSelectedBankId() => _selectedBankId;
        public string GetSelectedBankName() => _selectedBankName;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
