/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 11:08:17
 * Version: 1.0.153
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
