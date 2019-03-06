// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationOrganizationResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IfcPresentationLayerWithStyle", 259)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPresentationLayerWithStyle>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPresentationLayerWithStyle(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_layerStyles = new ItemSet<IfcPresentationStyleSelect>( this, 0,  8);
		}

		#region Explicit attribute fields
		private bool? _layerOn;
		private bool? _layerFrozen;
		private bool? _layerBlocked;
		private readonly ItemSet<IfcPresentationStyleSelect> _layerStyles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public bool? @LayerOn 
		{ 
			get 
			{
				if(_activated) return _layerOn;
				Activate();
				return _layerOn;
			} 
			set
			{
				SetValue( v =>  _layerOn = v, _layerOn, value,  "LayerOn", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public bool? @LayerFrozen 
		{ 
			get 
			{
				if(_activated) return _layerFrozen;
				Activate();
				return _layerFrozen;
			} 
			set
			{
				SetValue( v =>  _layerFrozen = v, _layerFrozen, value,  "LayerFrozen", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public bool? @LayerBlocked 
		{ 
			get 
			{
				if(_activated) return _layerBlocked;
				Activate();
				return _layerBlocked;
			} 
			set
			{
				SetValue( v =>  _layerBlocked = v, _layerBlocked, value,  "LayerBlocked", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IItemSet<IfcPresentationStyleSelect> @LayerStyles 
		{ 
			get 
			{
				if(_activated) return _layerStyles;
				Activate();
				return _layerStyles;
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
					_layerOn = value.BooleanVal;
					return;
				case 5: 
					_layerFrozen = value.BooleanVal;
					return;
				case 6: 
					_layerBlocked = value.BooleanVal;
					return;
				case 7: 
					_layerStyles.InternalAdd((IfcPresentationStyleSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPresentationLayerWithStyle other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @AssignedItems)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @AssignedItems)
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