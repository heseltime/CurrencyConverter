using CurrencyConverter.Blazor.Services.Generated;
using Microsoft.AspNetCore.Components;

namespace CurrencyConverter.Blazor.Pages
{
    public partial class CurrencyList
    {
        [Inject]
        public IConverterService ConverterService { get; set; } = null!;

        private IEnumerable<CurrencyData>? currencies;

        private double sourceValue = 1;

        private async Task RefreshAsync()
        {
            var response = await ConverterService.GetAllAsync();
            currencies = response.Result;
        }

        protected override async Task OnInitializedAsync()
        {
            await RefreshAsync();
        }
    }
}
