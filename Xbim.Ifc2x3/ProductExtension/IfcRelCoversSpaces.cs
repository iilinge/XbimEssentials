// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelCoversSpaces", 17)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelCoversSpaces : IfcRelConnects, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelCoversSpaces>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelCoversSpaces(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedCoverings = new ItemSet<IfcCovering>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcSpace _relatedSpace;
		private readonly ItemSet<IfcCovering> _relatedCoverings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcSpace @RelatedSpace 
		{ 
			get 
			{
				if(_activated) return _relatedSpace;
				Activate();
				return _relatedSpace;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedSpace = v, _relatedSpace, value,  "RelatedSpace", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcCovering> @RelatedCoverings 
		{ 
			get 
			{
				if(_activated) return _relatedCoverings;
				Activate();
				return _relatedCoverings;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedSpace = (IfcSpace)(value.EntityVal);
					return;
				case 5: 
					_relatedCoverings.InternalAdd((IfcCovering)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelCoversSpaces other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@RelatedSpace != null)
					yield return @RelatedSpace;
				foreach(var entity in @RelatedCoverings)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatedSpace != null)
					yield return @RelatedSpace;
				foreach(var entity in @RelatedCoverings)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}