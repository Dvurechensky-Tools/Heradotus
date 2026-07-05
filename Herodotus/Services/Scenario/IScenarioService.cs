/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 июля 2026 11:15:04
 * Version: 1.0.249
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
