//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "be0b1ba9d423f3b7")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.5")]

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "contentBase"
	/// <summary>Content Base</summary>
	public partial interface IContentBase : IPublishedContent
	{
		/// <summary>Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		global::Newtonsoft.Json.Linq.JToken BodyText { get; }

		/// <summary>Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		string PageTitle { get; }
	}

	/// <summary>Content Base</summary>
	[PublishedModel("contentBase")]
	public partial class ContentBase : PublishedContentModel, IContentBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contentBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentBase(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::Newtonsoft.Json.Linq.JToken BodyText => GetBodyText(this);

		/// <summary>Static getter for Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static global::Newtonsoft.Json.Linq.JToken GetBodyText(IContentBase that) => that.Value<global::Newtonsoft.Json.Linq.JToken>("bodyText");

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => GetPageTitle(this);

		/// <summary>Static getter for Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static string GetPageTitle(IContentBase that) => that.Value<string>("pageTitle");
	}

	// Mixin Content Type with alias "navigationBase"
	/// <summary>Navigation Base</summary>
	public partial interface INavigationBase : IPublishedContent
	{
		/// <summary>Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		global::System.Collections.Generic.IEnumerable<string> Keywords { get; }

		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		string SeoMetaDescription { get; }

		/// <summary>Hide in Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		bool UmbracoNavihide { get; }
	}

	/// <summary>Navigation Base</summary>
	[PublishedModel("navigationBase")]
	public partial class NavigationBase : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "navigationBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavigationBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public NavigationBase(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => GetKeywords(this);

		/// <summary>Static getter for Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static global::System.Collections.Generic.IEnumerable<string> GetKeywords(INavigationBase that) => that.Value<global::System.Collections.Generic.IEnumerable<string>>("keywords");

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => GetSeoMetaDescription(this);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static string GetSeoMetaDescription(INavigationBase that) => that.Value<string>("seoMetaDescription");

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => GetUmbracoNavihide(this);

		/// <summary>Static getter for Hide in Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static bool GetUmbracoNavihide(INavigationBase that) => that.Value<bool>("umbracoNavihide");
	}

	/// <summary>Person</summary>
	[PublishedModel("person")]
	public partial class Person : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "person";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Person, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Person(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Instagram Username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("instagramUsername")]
		public string InstagramUsername => this.Value<string>("instagramUsername");

		///<summary>
		/// Photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("photo")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Photo => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("photo");

		///<summary>
		/// Twitter username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("twitterUsername")]
		public string TwitterUsername => this.Value<string>("twitterUsername");

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}

	/// <summary>People</summary>
	[PublishedModel("people")]
	public partial class People : PublishedContentModel, IContentBase, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "people";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<People, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public People(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Featured People
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("featuredPeople")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> FeaturedPeople => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("featuredPeople");

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::Newtonsoft.Json.Linq.JToken BodyText => global::Umbraco.Web.PublishedModels.ContentBase.GetBodyText(this);

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.ContentBase.GetPageTitle(this);

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}

	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Color Theme
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("colorTheme")]
		public string ColorTheme => this.Value<string>("colorTheme");

		///<summary>
		/// Font
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("font")]
		public string Font => this.Value<string>("font");

		///<summary>
		/// Hero Background: Spice up the homepage by adding a beautiful photo that relates to your business
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("HeroBackgroundImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent HeroBackgroundImage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("HeroBackgroundImage");

		///<summary>
		/// Call To Action Caption: The caption on the button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("heroCTACaption")]
		public string HeroCtacaption => this.Value<string>("heroCTACaption");

		///<summary>
		/// Call To Action Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("HeroCtalink")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent HeroCtalink => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("HeroCtalink");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("heroDescription")]
		public string HeroDescription => this.Value<string>("heroDescription");

		///<summary>
		/// Header: This is the main headline for the hero area on the Homepage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("heroHeader")]
		public string HeroHeader => this.Value<string>("heroHeader");

		///<summary>
		/// Logo: Optional. If you add a logo it'll be used in the upper left corner instead of the site name. Make sure to use a transparent logo for best results
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("SiteLogo")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent SiteLogo => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("SiteLogo");

		///<summary>
		/// Sitename: Used on the homepage as well as the title and social cards
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("sitename")]
		public string Sitename => this.Value<string>("sitename");
	}

	/// <summary>Feature</summary>
	[PublishedModel("feature")]
	public partial class Feature : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "feature";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Feature, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Feature(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Details
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("featureDetails")]
		public string FeatureDetails => this.Value<string>("featureDetails");

		///<summary>
		/// Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("featureName")]
		public string FeatureName => this.Value<string>("featureName");
	}

	/// <summary>Content Page</summary>
	[PublishedModel("contentPage")]
	public partial class ContentPage : PublishedContentModel, IContentBase, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contentPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("bodyText")]
		public global::Newtonsoft.Json.Linq.JToken BodyText => global::Umbraco.Web.PublishedModels.ContentBase.GetBodyText(this);

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.ContentBase.GetPageTitle(this);

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}

	/// <summary>Contact</summary>
	[PublishedModel("contact")]
	public partial class Contact : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "contact";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Contact(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Contact Form Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("contactFormHeader")]
		public string ContactFormHeader => this.Value<string>("contactFormHeader");

		///<summary>
		/// Contact Intro
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("contactIntro")]
		public global::System.Web.IHtmlString ContactIntro => this.Value<global::System.Web.IHtmlString>("contactIntro");

		///<summary>
		/// Message: The body or text of the email being sent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("message")]
		public string Message => this.Value<string>("message");

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => this.Value<string>("pageTitle");

		///<summary>
		/// Recipient: The email address (or addresses) the email will be sent to
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("recipient")]
		public string Recipient => this.Value<string>("recipient");

		///<summary>
		/// Subject: The subject or name given to the email being sent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("subject")]
		public string Subject => this.Value<string>("subject");

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}

	/// <summary>Folder</summary>
	[PublishedModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Folder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Folder(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Image</summary>
	[PublishedModel("Image")]
	public partial class Image : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Image";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Image(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoFile")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue UmbracoFile => this.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("umbracoFile");

		///<summary>
		/// Height: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoHeight")]
		public int UmbracoHeight => this.Value<int>("umbracoHeight");

		///<summary>
		/// Width: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoWidth")]
		public int UmbracoWidth => this.Value<int>("umbracoWidth");
	}

	/// <summary>File</summary>
	[PublishedModel("File")]
	public partial class File : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "File";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public File(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload file
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Member</summary>
	[PublishedModel("Member")]
	public partial class Member : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const string ModelTypeAlias = "Member";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Member(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public int UmbracoMemberFailedPasswordAttempts => this.Value<int>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public global::System.DateTime UmbracoMemberLastLockoutDate => this.Value<global::System.DateTime>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public global::System.DateTime UmbracoMemberLastLogin => this.Value<global::System.DateTime>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public global::System.DateTime UmbracoMemberLastPasswordChangeDate => this.Value<global::System.DateTime>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalAnswer => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalQuestion => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalQuestion");
	}

}
