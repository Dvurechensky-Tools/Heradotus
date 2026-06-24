/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 июня 2026 10:56:52
 * Version: 1.0.239
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
