using MonoTouch.Foundation;
using System.CodeDom.Compiler;
using System;

namespace TTTAttributedLabelBindings {

	public partial class TTTAttributedLabel {
		public virtual void AddLinkToText(string text, string url) {
			var index = Text.IndexOf (text, StringComparison.CurrentCultureIgnoreCase);
			this.AddLinkToURL (new NSUrl(url), new NSRange(index, text.Length));
		}
	}
}