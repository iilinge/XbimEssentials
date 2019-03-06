// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcDraughtingCallout", 222)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDraughtingCallout : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcDraughtingCallout>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingCallout(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_contents = new ItemSet<IfcDraughtingCalloutElement>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcDraughtingCalloutElement> _contents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcDraughtingCalloutElement> @Contents 
		{ 
			get 
			{
				if(_activated) return _contents;
				Activate();
				return _contents;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedDraughtingCallout")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 4)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedFromCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => Equals(e.RelatedDraughtingCallout), "RelatedDraughtingCallout", this);
			} 
		}
		[InverseProperty("RelatingDraughtingCallout")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 5)]
		public IEnumerable<IfcDraughtingCalloutRelationship> @IsRelatedToCallout 
		{ 
			get 
			{
				return Model.Instances.Where<IfcDraughtingCalloutRelationship>(e => Equals(e.RelatingDraughtingCallout), "RelatingDraughtingCallout", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_contents.InternalAdd((IfcDraughtingCalloutElement)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDraughtingCallout other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Contents)
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