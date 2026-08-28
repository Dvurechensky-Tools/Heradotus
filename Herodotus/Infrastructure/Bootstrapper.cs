/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2026 07:13:51
 * Version: 1.0.303
 */

using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using Herodotus.Views;
using Herodotus.ViewModels;
using Herodotus.Services.Scenario;
using Herodotus.Services.Scenario.Implements;
namespace Herodotus
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IScenarioService, ScenarioService>();
            // окно закрытия приложения
            containerRegistry.RegisterDialog<StepCardView, StepCardViewModel>();
            containerRegistry.RegisterDialog<AddScenarioView, AddScenarioViewModel>();
        }
    }
}
