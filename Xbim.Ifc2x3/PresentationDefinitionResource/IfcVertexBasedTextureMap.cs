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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcVertexBasedTextureMap", 736)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexBasedTextureMap : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcVertexBasedTextureMap>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexBasedTextureMap(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_textureVertices = new ItemSet<IfcTextureVertex>( this, 0,  1);
			_texturePoints = new ItemSet<IfcCartesianPoint>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcTextureVertex> _textureVertices;
		private readonly ItemSet<IfcCartesianPoint> _texturePoints;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 3 }, new int [] { -1 }, 1)]
		public IItemSet<IfcTextureVertex> @TextureVertices 
		{ 
			get 
			{
				if(_activated) return _textureVertices;
				Activate();
				return _textureVertices;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 3 }, new int [] { -1 }, 2)]
		public IItemSet<IfcCartesianPoint> @TexturePoints 
		{ 
			get 
			{
				if(_activated) return _texturePoints;
				Activate();
				return _texturePoints;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textureVertices.InternalAdd((IfcTextureVertex)value.EntityVal);
					return;
				case 1: 
					_texturePoints.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVertexBasedTextureMap other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @TextureVertices)
					yield return entity;
				foreach(var entity in @TexturePoints)
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