/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 декабря 2025 06:53:25
 * Version: 1.0.48
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
