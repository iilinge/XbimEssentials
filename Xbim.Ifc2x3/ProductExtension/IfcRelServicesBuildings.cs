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
	[ExpressType("IfcRelServicesBuildings", 600)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelServicesBuildings : IfcRelConnects, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelServicesBuildings>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelServicesBuildings(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedBuildings = new ItemSet<IfcSpatialStructureElement>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcSystem _relatingSystem;
		private readonly ItemSet<IfcSpatialStructureElement> _relatedBuildings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcSystem @RelatingSystem 
		{ 
			get 
			{
				if(_activated) return _relatingSystem;
				Activate();
				return _relatingSystem;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingSystem = v, _relatingSystem, value,  "RelatingSystem", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcSpatialStructureElement> @RelatedBuildings 
		{ 
			get 
			{
				if(_activated) return _relatedBuildings;
				Activate();
				return _relatedBuildings;
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
					_relatingSystem = (IfcSystem)(value.EntityVal);
					return;
				case 5: 
					_relatedBuildings.InternalAdd((IfcSpatialStructureElement)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelServicesBuildings other)
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
				if (@RelatingSystem != null)
					yield return @RelatingSystem;
				foreach(var entity in @RelatedBuildings)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingSystem != null)
					yield return @RelatingSystem;
				foreach(var entity in @RelatedBuildings)
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