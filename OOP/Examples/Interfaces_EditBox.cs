using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    // Inherit Interfaces
    interface IControl
    {
        void Paint();
    }
    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }

    // Implement many interfaces in a class
    interface IDataBound
    {
        void Bind(Binder b);
    }
    public class Interfaces_EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }
}
