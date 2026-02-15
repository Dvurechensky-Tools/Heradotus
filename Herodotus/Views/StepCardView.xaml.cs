/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 февраля 2026 06:53:25
 * Version: 1.0.109
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
