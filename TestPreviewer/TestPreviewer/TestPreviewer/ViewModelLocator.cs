using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPreviewer.ViewModels;

namespace TestPreviewer
{
    public static class ViewModelLocator
    {
        private static MainPageViewModel mainpageVM;

        public static MainPageViewModel MainPageViewModel
        => mainpageVM ?? (mainpageVM = new MainPageViewModel() { Message = "This is sample data." });
    }
}