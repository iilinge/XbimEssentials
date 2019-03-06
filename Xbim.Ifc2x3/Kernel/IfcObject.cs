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
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcObject", 21)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObject : IfcObjectDefinition, IEquatable<@IfcObject>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObject(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(_activated) return _objectType;
				Activate();
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType", 5);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 10)]
		public IEnumerable<IfcRelDefines> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefines>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
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
					_objectType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObject other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}