/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:11:50
 * Version: 1.0.145
 */

using Prism.Mvvm;

namespace Herodotus.Models
{
    public class StepItemModel : BindableBase
    {
        /// <summary>
        /// Имя шага
        /// </summary>
        private string _header;
        public string Header
        {
            get => _header;
            set => SetProperty(ref _header, value);
        }
        /// <summary>
        /// Полное название
        /// </summary>
        private string _content;
        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }
        /// <summary>
        /// Дополнительное описание
        /// </summary>
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
    }
}
