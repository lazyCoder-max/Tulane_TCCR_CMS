//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.3.2+e7fae14
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "staff"
	/// <summary>Staff</summary>
	public partial interface IStaff : IPublishedContent
	{
		/// <summary>Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Address { get; }

		/// <summary>Biography</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Biography { get; }

		/// <summary>Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Email { get; }

		/// <summary>Persons Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PersonsName { get; }

		/// <summary>Phone Number</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		int PhoneNumber { get; }

		/// <summary>Photo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops Photo { get; }

		/// <summary>Designation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Role { get; }
	}

	/// <summary>Staff</summary>
	[PublishedModel("staff")]
	public partial class Staff : PublishedContentModel, IStaff
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "staff";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Staff, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Staff(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("address")]
		public virtual string Address => GetAddress(this, _publishedValueFallback);

		/// <summary>Static getter for Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetAddress(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "address");

		///<summary>
		/// Biography
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("biography")]
		public virtual string Biography => GetBiography(this, _publishedValueFallback);

		/// <summary>Static getter for Biography</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetBiography(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "biography");

		///<summary>
		/// Email: Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("email")]
		public virtual string Email => GetEmail(this, _publishedValueFallback);

		/// <summary>Static getter for Email</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetEmail(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "email");

		///<summary>
		/// Persons Name: Name of the Staff
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("personsName")]
		public virtual string PersonsName => GetPersonsName(this, _publishedValueFallback);

		/// <summary>Static getter for Persons Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPersonsName(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "personsName");

		///<summary>
		/// Phone Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[ImplementPropertyType("phoneNumber")]
		public virtual int PhoneNumber => GetPhoneNumber(this, _publishedValueFallback);

		/// <summary>Static getter for Phone Number</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public static int GetPhoneNumber(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "phoneNumber");

		///<summary>
		/// Photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("photo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Photo => GetPhoto(this, _publishedValueFallback);

		/// <summary>Static getter for Photo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetPhoto(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "photo");

		///<summary>
		/// Designation: Enter the staff's role
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("role")]
		public virtual string Role => GetRole(this, _publishedValueFallback);

		/// <summary>Static getter for Designation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetRole(IStaff that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "role");
	}
}
