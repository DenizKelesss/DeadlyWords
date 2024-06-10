//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Articy.Zombo
{
    
    
    public class Jump : ArticyObject, IJump, IPropertyProvider, IInputPinsOwner, IOutputPinsOwner, IObjectWithColor, IObjectWithText, IObjectWithExternalId, IObjectWithShortId, IObjectWithPosition, IObjectWithZIndex, IObjectWithSize, IObjectWithTarget
    {
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private ArticyValueArticyString mText = new ArticyValueArticyString();
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Vector2 mPosition;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        [SerializeField()]
        private ArticyValueArticyObject mTarget = new ArticyValueArticyObject();
        
        [SerializeField()]
        private UInt64 mTargetPin;
        
        [SerializeField()]
        private ArticyValueListInputPin mInputPins = new ArticyValueListInputPin();
        
        [SerializeField()]
        private ArticyValueListOutputPin mOutputPins = new ArticyValueListOutputPin();
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                var oldValue = mColor;
                mColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Color", oldValue, mColor);
            }
        }
        
        public ArticyString Text
        {
            get
            {
                return mText.GetValue();
            }
            set
            {
                mText.SetValue(value);
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                var oldValue = mExternalId;
                mExternalId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ExternalId", oldValue, mExternalId);
            }
        }
        
        public Vector2 Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                var oldValue = mPosition;
                mPosition = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Position", oldValue, mPosition);
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                var oldValue = mZIndex;
                mZIndex = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ZIndex", oldValue, mZIndex);
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                var oldValue = mSize;
                mSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Size", oldValue, mSize);
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                var oldValue = mShortId;
                mShortId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShortId", oldValue, mShortId);
            }
        }
        
        public ArticyObject Target
        {
            get
            {
                return mTarget.GetValue();
            }
            set
            {
                var oldValue = mTarget;
                mTarget.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Target", oldValue.GetValue(), mTarget.GetValue());
            }
        }
        
        public UInt64 TargetPin
        {
            get
            {
                return mTargetPin;
            }
            set
            {
                var oldValue = mTargetPin;
                mTargetPin = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "TargetPin", oldValue, mTargetPin);
            }
        }
        
        public List<InputPin> InputPins
        {
            get
            {
                return mInputPins.GetValue();
            }
            set
            {
                var oldValue = mInputPins;
                mInputPins.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "InputPins", oldValue.GetValue(), mInputPins.GetValue());
            }
        }
        
        public List<OutputPin> OutputPins
        {
            get
            {
                return mOutputPins.GetValue();
            }
            set
            {
                var oldValue = mOutputPins;
                mOutputPins.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutputPins", oldValue.GetValue(), mOutputPins.GetValue());
            }
        }
        
        public List<Articy.Unity.Interfaces.IInputPin> GetInputPins()
        {
            return InputPins.Cast<IInputPin>().ToList();
        }
        
        public List<Articy.Unity.Interfaces.IOutputPin> GetOutputPins()
        {
            return OutputPins.Cast<IOutputPin>().ToList();
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Jump newClone = ((Jump)(aClone));
            newClone.Color = Color;
            if ((mText != null))
            {
                newClone.mText = ((ArticyValueArticyString)(mText.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.ExternalId = ExternalId;
            newClone.Position = Position;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            if ((mTarget != null))
            {
                newClone.mTarget = ((ArticyValueArticyObject)(mTarget.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.TargetPin = TargetPin;
            List<InputPin> temp_InputPins = new List<InputPin>();
            int i = 0;
            for (i = 0; (i < InputPins.Count); i = (i + 1))
            {
                temp_InputPins.Add(((InputPin)(InputPins[i].CloneObject(newClone, aFirstClassParent))));
            }
            newClone.InputPins = temp_InputPins;
            List<OutputPin> temp_OutputPins = new List<OutputPin>();
            for (i = 0; (i < OutputPins.Count); i = (i + 1))
            {
                temp_OutputPins.Add(((OutputPin)(OutputPins[i].CloneObject(newClone, aFirstClassParent))));
            }
            newClone.OutputPins = temp_OutputPins;
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Position"))
            {
                Position = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            if ((aProperty == "Target"))
            {
                Target = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "TargetPin"))
            {
                TargetPin = ((UInt64)(aValue));
                return;
            }
            if ((aProperty == "InputPins"))
            {
                InputPins = ((List<InputPin>)(aValue));
                return;
            }
            if ((aProperty == "OutputPins"))
            {
                OutputPins = ((List<OutputPin>)(aValue));
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "Position"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Position);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            if ((aProperty == "Target"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Target);
            }
            if ((aProperty == "TargetPin"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(TargetPin);
            }
            if ((aProperty == "InputPins"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InputPins);
            }
            if ((aProperty == "OutputPins"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutputPins);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
