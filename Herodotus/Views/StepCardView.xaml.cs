/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:33:06
 * Version: 1.0.58
 */

using System.Windows;

namespace Herodotus.Views
{
    public partial class StepCardView : System.Windows.Controls.UserControl
    {
        public StepCardView()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            // Сбрасываем активную карточку
            if (DataContext is ViewModels.MainWindowViewModel vm)
            {
                vm.ActiveStepCard = null;
            }
        }
    }
}
