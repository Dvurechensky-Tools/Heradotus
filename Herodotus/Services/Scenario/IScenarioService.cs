/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 мая 2026 10:37:28
 * Version: 1.0.203
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
