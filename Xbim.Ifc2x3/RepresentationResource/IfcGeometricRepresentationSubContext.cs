// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcGeometricRepresentationSubContext", 556)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcGeometricRepresentationSubContext>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationSubContext(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationContext _parentContext;
		private IfcPositiveRatioMeasure? _targetScale;
		private IfcGeometricProjectionEnum _targetView;
		private IfcLabel? _userDefinedTargetView;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 9)]
		public IfcGeometricRepresentationContext @ParentContext 
		{ 
			get 
			{
				if(_activated) return _parentContext;
				Activate();
				return _parentContext;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _parentContext = v, _parentContext, value,  "ParentContext", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveRatioMeasure? @TargetScale 
		{ 
			get 
			{
				if(_activated) return _targetScale;
				Activate();
				return _targetScale;
			} 
			set
			{
				SetValue( v =>  _targetScale = v, _targetScale, value,  "TargetScale", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 11)]
		public IfcGeometricProjectionEnum @TargetView 
		{ 
			get 
			{
				if(_activated) return _targetView;
				Activate();
				return _targetView;
			} 
			set
			{
				SetValue( v =>  _targetView = v, _targetView, value,  "TargetView", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcLabel? @UserDefinedTargetView 
		{ 
			get 
			{
				if(_activated) return _userDefinedTargetView;
				Activate();
				return _userDefinedTargetView;
			} 
			set
			{
				SetValue( v =>  _userDefinedTargetView = v, _userDefinedTargetView, value,  "UserDefinedTargetView", 10);
			} 
		}	
		#endregion

		#region Overriding attributes
		[EntityAttribute(5, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public override IfcAxis2Placement @WorldCoordinateSystem 
		{
			get 
			{
				return ParentContext.WorldCoordinateSystem;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property WorldCoordinateSystem in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(3, EntityAttributeState.DerivedOverride, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public override IfcDimensionCount @CoordinateSpaceDimension 
		{
			get 
			{
				return ParentContext.CoordinateSpaceDimension;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property CoordinateSpaceDimension in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(6, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public override IfcDirection @TrueNorth 
		{
			get 
			{
				return ParentContext.TrueNorth ?? WorldCoordinateSystem.P[2];
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property TrueNorth in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(4, EntityAttributeState.DerivedOverride, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public override double? @Precision 
		{
			get 
			{
				return ParentContext.Precision ?? 1E-05;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property Precision in IfcGeometricRepresentationSubContext"); 
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
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_parentContext = (IfcGeometricRepresentationContext)(value.EntityVal);
					return;
				case 7: 
					_targetScale = value.RealVal;
					return;
				case 8: 
                    _targetView = (IfcGeometricProjectionEnum) System.Enum.Parse(typeof (IfcGeometricProjectionEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedTargetView = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeometricRepresentationSubContext other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@WorldCoordinateSystem != null)
					yield return @WorldCoordinateSystem;
				if (@TrueNorth != null)
					yield return @TrueNorth;
				if (@ParentContext != null)
					yield return @ParentContext;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ParentContext != null)
					yield return @ParentContext;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}