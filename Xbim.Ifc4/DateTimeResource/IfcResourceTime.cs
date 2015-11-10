// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcResourceTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcResourceTime : IIfcSchedulingTime
	{
		IfcDuration? @ScheduleWork { get; }
		IfcPositiveRatioMeasure? @ScheduleUsage { get; }
		IfcDateTime? @ScheduleStart { get; }
		IfcDateTime? @ScheduleFinish { get; }
		IfcLabel? @ScheduleContour { get; }
		IfcDuration? @LevelingDelay { get; }
		bool? @IsOverAllocated { get; }
		IfcDateTime? @StatusTime { get; }
		IfcDuration? @ActualWork { get; }
		IfcPositiveRatioMeasure? @ActualUsage { get; }
		IfcDateTime? @ActualStart { get; }
		IfcDateTime? @ActualFinish { get; }
		IfcDuration? @RemainingWork { get; }
		IfcPositiveRatioMeasure? @RemainingUsage { get; }
		IfcPositiveRatioMeasure? @Completion { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IFCRESOURCETIME", 958)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceTime : IfcSchedulingTime, IInstantiableEntity, IIfcResourceTime, IEqualityComparer<@IfcResourceTime>, IEquatable<@IfcResourceTime>
	{
		#region IIfcResourceTime explicit implementation
		IfcDuration? IIfcResourceTime.ScheduleWork { get { return @ScheduleWork; } }	
		IfcPositiveRatioMeasure? IIfcResourceTime.ScheduleUsage { get { return @ScheduleUsage; } }	
		IfcDateTime? IIfcResourceTime.ScheduleStart { get { return @ScheduleStart; } }	
		IfcDateTime? IIfcResourceTime.ScheduleFinish { get { return @ScheduleFinish; } }	
		IfcLabel? IIfcResourceTime.ScheduleContour { get { return @ScheduleContour; } }	
		IfcDuration? IIfcResourceTime.LevelingDelay { get { return @LevelingDelay; } }	
		bool? IIfcResourceTime.IsOverAllocated { get { return @IsOverAllocated; } }	
		IfcDateTime? IIfcResourceTime.StatusTime { get { return @StatusTime; } }	
		IfcDuration? IIfcResourceTime.ActualWork { get { return @ActualWork; } }	
		IfcPositiveRatioMeasure? IIfcResourceTime.ActualUsage { get { return @ActualUsage; } }	
		IfcDateTime? IIfcResourceTime.ActualStart { get { return @ActualStart; } }	
		IfcDateTime? IIfcResourceTime.ActualFinish { get { return @ActualFinish; } }	
		IfcDuration? IIfcResourceTime.RemainingWork { get { return @RemainingWork; } }	
		IfcPositiveRatioMeasure? IIfcResourceTime.RemainingUsage { get { return @RemainingUsage; } }	
		IfcPositiveRatioMeasure? IIfcResourceTime.Completion { get { return @Completion; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDuration? _scheduleWork;
		private IfcPositiveRatioMeasure? _scheduleUsage;
		private IfcDateTime? _scheduleStart;
		private IfcDateTime? _scheduleFinish;
		private IfcLabel? _scheduleContour;
		private IfcDuration? _levelingDelay;
		private bool? _isOverAllocated;
		private IfcDateTime? _statusTime;
		private IfcDuration? _actualWork;
		private IfcPositiveRatioMeasure? _actualUsage;
		private IfcDateTime? _actualStart;
		private IfcDateTime? _actualFinish;
		private IfcDuration? _remainingWork;
		private IfcPositiveRatioMeasure? _remainingUsage;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ScheduleWork 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleWork;
				((IPersistEntity)this).Activate(false);
				return _scheduleWork;
			} 
			set
			{
				SetValue( v =>  _scheduleWork = v, _scheduleWork, value,  "ScheduleWork");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ScheduleUsage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleUsage;
				((IPersistEntity)this).Activate(false);
				return _scheduleUsage;
			} 
			set
			{
				SetValue( v =>  _scheduleUsage = v, _scheduleUsage, value,  "ScheduleUsage");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleStart;
				((IPersistEntity)this).Activate(false);
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ScheduleFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleFinish;
				((IPersistEntity)this).Activate(false);
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ScheduleContour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scheduleContour;
				((IPersistEntity)this).Activate(false);
				return _scheduleContour;
			} 
			set
			{
				SetValue( v =>  _scheduleContour = v, _scheduleContour, value,  "ScheduleContour");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @LevelingDelay 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _levelingDelay;
				((IPersistEntity)this).Activate(false);
				return _levelingDelay;
			} 
			set
			{
				SetValue( v =>  _levelingDelay = v, _levelingDelay, value,  "LevelingDelay");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @IsOverAllocated 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isOverAllocated;
				((IPersistEntity)this).Activate(false);
				return _isOverAllocated;
			} 
			set
			{
				SetValue( v =>  _isOverAllocated = v, _isOverAllocated, value,  "IsOverAllocated");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @StatusTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _statusTime;
				((IPersistEntity)this).Activate(false);
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @ActualWork 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualWork;
				((IPersistEntity)this).Activate(false);
				return _actualWork;
			} 
			set
			{
				SetValue( v =>  _actualWork = v, _actualWork, value,  "ActualWork");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @ActualUsage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualUsage;
				((IPersistEntity)this).Activate(false);
				return _actualUsage;
			} 
			set
			{
				SetValue( v =>  _actualUsage = v, _actualUsage, value,  "ActualUsage");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualStart;
				((IPersistEntity)this).Activate(false);
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @ActualFinish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actualFinish;
				((IPersistEntity)this).Activate(false);
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDuration? @RemainingWork 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _remainingWork;
				((IPersistEntity)this).Activate(false);
				return _remainingWork;
			} 
			set
			{
				SetValue( v =>  _remainingWork = v, _remainingWork, value,  "RemainingWork");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @RemainingUsage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _remainingUsage;
				((IPersistEntity)this).Activate(false);
				return _remainingUsage;
			} 
			set
			{
				SetValue( v =>  _remainingUsage = v, _remainingUsage, value,  "RemainingUsage");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _completion;
				((IPersistEntity)this).Activate(false);
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_scheduleWork = value.StringVal;
					return;
				case 4: 
					_scheduleUsage = value.RealVal;
					return;
				case 5: 
					_scheduleStart = value.StringVal;
					return;
				case 6: 
					_scheduleFinish = value.StringVal;
					return;
				case 7: 
					_scheduleContour = value.StringVal;
					return;
				case 8: 
					_levelingDelay = value.StringVal;
					return;
				case 9: 
					_isOverAllocated = value.BooleanVal;
					return;
				case 10: 
					_statusTime = value.StringVal;
					return;
				case 11: 
					_actualWork = value.StringVal;
					return;
				case 12: 
					_actualUsage = value.RealVal;
					return;
				case 13: 
					_actualStart = value.StringVal;
					return;
				case 14: 
					_actualFinish = value.StringVal;
					return;
				case 15: 
					_remainingWork = value.StringVal;
					return;
				case 16: 
					_remainingUsage = value.RealVal;
					return;
				case 17: 
					_completion = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResourceTime other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcResourceTime
            var root = (@IfcResourceTime)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcResourceTime left, @IfcResourceTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcResourceTime left, @IfcResourceTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcResourceTime x, @IfcResourceTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcResourceTime obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}