//using BootstrapBlazor.Components;
//using Microsoft.AspNetCore.Components;

//< div class= "col-md-4 mb-3 d-flex align-items-center" >
//    < label for= "yearInput" class= "me-1 fw-bold" style = "white-space: nowrap; min-width: 120px;" > Filter by Year:</ label >
//    < input type = "text" class= "form-control me-2" placeholder = "Type Year..." id = "yearInput" @bind = "typedYear" @bind:event="oninput" />
//    <select class= "form-control flex-grow-1" id = "yearDropdown" @onchange = "OnYearChanged" >
//        < option value = "" > Select Year </ option >
//        @foreach(var year in years)
//        {
//            < option value = "@year" > @year </ option >
//        }
//    </ select >
//</ div >
//@code {
//    private string? typedYear;

//private async Task OnYearChanged(ChangeEventArgs e)
//{
//    if (int.TryParse(e.Value?.ToString(), out int year))
//    {
//        selectedYear = year;
//    }
//    else
//    {
//        selectedYear = null;
//    }

//    // If the typed year is valid, set it as the selected year
//    if (int.TryParse(typedYear, out int typedYearValue))
//    {
//        selectedYear = typedYearValue;
//    }

//    await LoadCreditDebitData();
//}

//private void ApplyFilters()
//{
//    var filteredList = new List<InsuredDetailView>(originalInsuredDetailsList);

//    // Filter by year
//    if (selectedYear.HasValue)
//    {
//        filteredList = filteredList
//            .Where(x => x.Coverage?.Effective_Date.Year == selectedYear.Value)
//            .ToList();
//    }

//    // Existing filters for amount and search text...
//    // (Keep the existing filtering logic here)
//}
//}