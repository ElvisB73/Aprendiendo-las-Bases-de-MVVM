using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace CalculadoraMvvm.viewmodels
{
    public partial class mainviewmodel : ObservableObject
    {
        private int _count;

        [ObservableProperty]
        private string _counterText = "Click me";   // genera la propiedad CounterText

        [RelayCommand]
        private void Increment()                     // genera IncrementCommand
        {
            _count++;

            CounterText = _count == 1
                ? $"Clicked {_count} time"
                : $"Clicked {_count} times";

            SemanticScreenReader.Announce(_counterText);
        }
    }
}
