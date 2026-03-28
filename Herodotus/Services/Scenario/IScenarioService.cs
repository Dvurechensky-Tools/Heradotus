/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:13:02
 * Version: 1.0.150
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
