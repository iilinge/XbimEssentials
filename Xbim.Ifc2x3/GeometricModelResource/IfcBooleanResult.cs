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
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcBooleanResult", 339)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanResult : IfcGeometricRepresentationItem, IInstantiableEntity, IfcBooleanOperand, IfcCsgSelect, IContainsEntityReferences, IEquatable<@IfcBooleanResult>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanResult(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcBooleanOperator _operator;
		private IfcBooleanOperand _firstOperand;
		private IfcBooleanOperand _secondOperand;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcBooleanOperator @Operator 
		{ 
			get 
			{
				if(_activated) return _operator;
				Activate();
				return _operator;
			} 
			set
			{
				SetValue( v =>  _operator = v, _operator, value,  "Operator", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcBooleanOperand @FirstOperand 
		{ 
			get 
			{
				if(_activated) return _firstOperand;
				Activate();
				return _firstOperand;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _firstOperand = v, _firstOperand, value,  "FirstOperand", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcBooleanOperand @SecondOperand 
		{ 
			get 
			{
				if(_activated) return _secondOperand;
				Activate();
				return _secondOperand;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _secondOperand = v, _secondOperand, value,  "SecondOperand", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return _firstOperand.Dim;
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _operator = (IfcBooleanOperator) System.Enum.Parse(typeof (IfcBooleanOperator), value.EnumVal, true);
					return;
				case 1: 
					_firstOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				case 2: 
					_secondOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBooleanResult other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@FirstOperand != null)
					yield return @FirstOperand;
				if (@SecondOperand != null)
					yield return @SecondOperand;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}