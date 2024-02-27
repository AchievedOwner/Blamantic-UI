using BlamanticUI.Abstractions;

using ComponentBuilder.Definitions;

namespace BlamanticUI;

[CssClass("button")]
[HtmlTag("button")]
public class Button : BlazorComponentBase, IUIComponent, IHasChildContent
{
	/// <summary>
	/// <inheritdoc/>
	/// </summary>
	[Parameter] public RenderFragment? ChildContent { get; set; }
}
