// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.QuantityResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.QuantityResource
{
	[ExpressType("IfcQuantityWeight", 603)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityWeight : IfcPhysicalSimpleQuantity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcQuantityWeight>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityWeight(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMassMeasure _weightValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcMassMeasure @WeightValue 
		{ 
			get 
			{
				if(_activated) return _weightValue;
				Activate();
				return _weightValue;
			} 
			set
			{
				SetValue( v =>  _weightValue = v, _weightValue, value,  "WeightValue", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_weightValue = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityWeight other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}