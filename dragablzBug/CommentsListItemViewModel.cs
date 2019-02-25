using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragablzBug
{
    /// <summary>
     /// Viewmodel which display an item 
     /// </summary>
    public class CommentsListItemViewModel
    {
        private static int index = 0;
        #region public Properties
        public string Comment { get; set; }
        /// <summary>
        /// The name of the graph where the comment is attached
        /// </summary>
        public string GraphName { get; set; }
        /// <summary>
        /// The time where the comment must be display
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Display a text for the <see cref="Time"/> item when the <see cref="ItemType"/> is a header
        /// </summary>
        public string TimeText { get; set; }
        /// <summary>
        /// Set the visibility of the comment in its associated graph
        /// </summary>
        public bool IsVisible { get; set; }
        /// <summary>
        /// Display a text for the <see cref="IsVisible"/> item when the <see cref="ItemType"/> is a header
        /// </summary>
        public string VisibilityText { get; set; }

        /// <summary>
        /// Get the number of the item
        /// </summary>
        public int Index { get; private set; }
        #endregion

        #region Constructor
        public CommentsListItemViewModel()
        {
            Index = index++;
        }
        #endregion
    }
}
