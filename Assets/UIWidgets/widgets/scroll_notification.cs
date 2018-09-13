using System.Collections.Generic;
using UIWidgets.gestures;
using UIWidgets.rendering;

namespace UIWidgets.widgets {
    public abstract class ScrollNotification : ViewportNotificationMixinLayoutChangedNotification {
        protected ScrollNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null
        ) {
            this.metrics = metrics;
            this.context = context;
        }

        public readonly ScrollMetrics metrics;

        public readonly BuildContext context;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            description.Add(this.metrics.ToString());
        }

        public static bool defaultScrollNotificationPredicate(ScrollNotification notification) {
            return notification.depth == 0;
        }
    }

    public class ScrollStartNotification : ScrollNotification {
        public ScrollStartNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null,
            DragStartDetails dragDetails = null
        ) : base(metrics: metrics, context: context) {
            this.dragDetails = dragDetails;
        }

        public readonly DragStartDetails dragDetails;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            if (this.dragDetails != null)
                description.Add(this.dragDetails.ToString());
        }
    }

    public class ScrollUpdateNotification : ScrollNotification {
        public ScrollUpdateNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null,
            DragUpdateDetails dragDetails = null,
            double scrollDelta = 0
        ) : base(metrics: metrics, context: context) {
            this.dragDetails = dragDetails;
            this.scrollDelta = scrollDelta;
        }

        public readonly DragUpdateDetails dragDetails;

        public readonly double scrollDelta;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            description.Add(string.Format("scrollDelta: {0}", this.scrollDelta));
            if (this.dragDetails != null) {
                description.Add(this.dragDetails.ToString());
            }
        }
    }

    public class OverscrollNotification : ScrollNotification {
        public OverscrollNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null,
            DragUpdateDetails dragDetails = null,
            double overscroll = 0,
            double velocity = 0
        ) : base(metrics: metrics, context: context) {
            this.dragDetails = dragDetails;
            this.overscroll = overscroll;
            this.velocity = velocity;
        }

        public readonly DragUpdateDetails dragDetails;

        public readonly double overscroll;

        public readonly double velocity;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            description.Add(string.Format("overscroll: {0:F1}", this.overscroll));
            description.Add(string.Format("velocity: {0:F1}", this.velocity));
            if (this.dragDetails != null) {
                description.Add(this.dragDetails.ToString());
            }
        }
    }

    public class ScrollEndNotification : ScrollNotification {
        public ScrollEndNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null,
            DragEndDetails dragDetails = null,
            double overscroll = 0,
            double velocity = 0
        ) : base(metrics: metrics, context: context) {
            this.dragDetails = dragDetails;
        }

        public readonly DragEndDetails dragDetails;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            if (this.dragDetails != null) {
                description.Add(this.dragDetails.ToString());
            }
        }
    }

    public class UserScrollNotification : ScrollNotification {
        public UserScrollNotification(
            ScrollMetrics metrics = null,
            BuildContext context = null,
            ScrollDirection direction = ScrollDirection.idle
        ) : base(metrics: metrics, context: context) {
            this.direction = direction;
        }

        public readonly ScrollDirection direction;

        protected override void debugFillDescription(List<string> description) {
            base.debugFillDescription(description);
            description.Add(string.Format("direction: {0}", this.direction));
        }
    }

    public delegate bool ScrollNotificationPredicate(ScrollNotification notification);
}