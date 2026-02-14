/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 февраля 2026 10:04:21
 * Version: 1.0.108
 */

using System.Collections.ObjectModel;

using Herodotus.Models;

namespace Herodotus.Services.Scenario
{
    public interface IScenarioService
    {
        ObservableCollection<ScenarioModel> LoadScenarios();
        void SaveScenario(ScenarioModel scenario);
        void SaveScenarios(ObservableCollection<ScenarioModel> scenarios);
        bool DeleteScenario(string scenarioName, ObservableCollection<ScenarioModel> scenarios = null);
    }
}
