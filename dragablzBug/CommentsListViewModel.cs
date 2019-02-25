using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragablzBug
{
    public class CommentsListViewModel
    {
        /// <summary>
        /// A list of CommentsListItemViewModel
        /// </summary>
        public ObservableCollection<CommentsListItemViewModel> Items { get; set; }

        public CommentsListViewModel()
        {
             
        }
    }
}
