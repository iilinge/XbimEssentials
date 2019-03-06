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
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcAnnotationFillArea", 173)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillArea : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcAnnotationFillArea>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillArea(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_innerBoundaries = new OptionalItemSet<IfcCurve>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcCurve _outerBoundary;
		private readonly OptionalItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(_activated) return _outerBoundary;
				Activate();
				return _outerBoundary;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(_activated) return _innerBoundaries;
				Activate();
				return _innerBoundaries;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationFillArea other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OuterBoundary != null)
					yield return @OuterBoundary;
				foreach(var entity in @InnerBoundaries)
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