using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement(Attributes = "asp-active")]
public class FooTagHelper : TagHelper
{
    [HtmlAttributeName("asp-active")]
    public bool Active { get; set; }






}