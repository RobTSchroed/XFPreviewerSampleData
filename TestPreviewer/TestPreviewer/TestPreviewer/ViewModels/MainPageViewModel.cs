using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreviewer.ViewModels
{
    public class MainPageViewModel
    {
        private string _message;

        public MainPageViewModel()
        {
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
            }
        }

        public static MainPageViewModel SampleData1()
        {
            return new MainPageViewModel()
            {
                Message = "This is sample data."
            };
        }

        public void Init()
        {
            Message = "This is runtime data.";
        }
    }
}