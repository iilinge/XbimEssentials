// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.MaterialResource
{
	[ExpressType("IfcMaterialLayer", 446)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayer : PersistEntity, IInstantiableEntity, IfcMaterialSelect, IfcObjectReferenceSelect, IContainsEntityReferences, IEquatable<@IfcMaterialLayer>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayer(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMaterial _material;
		private IfcPositiveLengthMeasure _layerThickness;
		private IfcLogical? _isVentilated;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(_activated) return _material;
				Activate();
				return _material;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _material = v, _material, value,  "Material", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcPositiveLengthMeasure @LayerThickness 
		{ 
			get 
			{
				if(_activated) return _layerThickness;
				Activate();
				return _layerThickness;
			} 
			set
			{
				SetValue( v =>  _layerThickness = v, _layerThickness, value,  "LayerThickness", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLogical? @IsVentilated 
		{ 
			get 
			{
				if(_activated) return _isVentilated;
				Activate();
				return _isVentilated;
			} 
			set
			{
				SetValue( v =>  _isVentilated = v, _isVentilated, value,  "IsVentilated", 3);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MaterialLayers")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, null, null, 4)]
		public IfcMaterialLayerSet @ToMaterialLayerSet 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this), "MaterialLayers", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 1: 
					_layerThickness = value.RealVal;
					return;
				case 2: 
					_isVentilated = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayer other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}