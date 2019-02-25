using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragablzBug
{
    /// <summary>
    /// Design model for CommentsListViewModel
    /// </summary>
    public class CommentsListDesignModel : CommentsListViewModel
    {
        private static CommentsListDesignModel instance;
        public static CommentsListDesignModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentsListDesignModel();
                return instance;
            }
        }

        #region Constructor
        public CommentsListDesignModel()
        {
            Items = new ObservableCollection<CommentsListItemViewModel>()
            {
                new CommentsListItemViewModel()
                {
                    Comment = "COMMENTS",
                    GraphName = "GRAPH XT",
                    Time = DateTime.Now,
                    VisibilityText = "VISIBLE",
                    TimeText = "Time",
                    IsVisible = true,


                },
                new CommentsListItemViewModel()
                {
                    Comment = "Woman Peacoat Lorem ipsum dolor sit amet Consectetur Lorem ipsum dolor sit amet Consectetur",
                    GraphName = "Graph XTqsdfqsdfsqfqsdf",
                    Time = DateTime.Now,
                    VisibilityText = "Visibility",
                    TimeText = "Time",
                    IsVisible = true

                },
                new CommentsListItemViewModel()
                {
                    Comment = "Woman Peacoat Lorem ipsum dolor  ipsum dolor sit amet Consectetur",
                    GraphName = "Graph XTqsdfqsdfsqfqsdf",
                    Time = DateTime.Now,
                    VisibilityText = "Visibility",
                    TimeText = "Time",
                    IsVisible = true

                },
                new CommentsListItemViewModel()
                {
                    Comment = "Woman Peacoat Lorem ipsum dolor sit amet Consectetur Lorem ipsum dolor sit amet Consectetur",
                    GraphName = "Graph XTqsdfqsdfsqfqsdf",
                    Time = DateTime.Now,
                    VisibilityText = "Visibility",
                    TimeText = "Time",
                    IsVisible = false

                }

            };

        }
        #endregion
    }
}
