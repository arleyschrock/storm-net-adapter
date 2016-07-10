#if !NETSTANDARD13
/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;



public partial class StormTopology : TBase
{

  public Dictionary<string, SpoutSpec> Spouts { get; set; }

  public Dictionary<string, Bolt> Bolts { get; set; }

  public Dictionary<string, StateSpoutSpec> State_spouts { get; set; }

  public StormTopology() {
  }

  public StormTopology(Dictionary<string, SpoutSpec> spouts, Dictionary<string, Bolt> bolts, Dictionary<string, StateSpoutSpec> state_spouts) : this() {
    this.Spouts = spouts;
    this.Bolts = bolts;
    this.State_spouts = state_spouts;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_spouts = false;
    bool isset_bolts = false;
    bool isset_state_spouts = false;
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.Map) {
            {
              Spouts = new Dictionary<string, SpoutSpec>();
              TMap _map22 = iprot.ReadMapBegin();
              for( int _i23 = 0; _i23 < _map22.Count; ++_i23)
              {
                string _key24;
                SpoutSpec _val25;
                _key24 = iprot.ReadString();
                _val25 = new SpoutSpec();
                _val25.Read(iprot);
                Spouts[_key24] = _val25;
              }
              iprot.ReadMapEnd();
            }
            isset_spouts = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Map) {
            {
              Bolts = new Dictionary<string, Bolt>();
              TMap _map26 = iprot.ReadMapBegin();
              for( int _i27 = 0; _i27 < _map26.Count; ++_i27)
              {
                string _key28;
                Bolt _val29;
                _key28 = iprot.ReadString();
                _val29 = new Bolt();
                _val29.Read(iprot);
                Bolts[_key28] = _val29;
              }
              iprot.ReadMapEnd();
            }
            isset_bolts = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.Map) {
            {
              State_spouts = new Dictionary<string, StateSpoutSpec>();
              TMap _map30 = iprot.ReadMapBegin();
              for( int _i31 = 0; _i31 < _map30.Count; ++_i31)
              {
                string _key32;
                StateSpoutSpec _val33;
                _key32 = iprot.ReadString();
                _val33 = new StateSpoutSpec();
                _val33.Read(iprot);
                State_spouts[_key32] = _val33;
              }
              iprot.ReadMapEnd();
            }
            isset_state_spouts = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
    if (!isset_spouts)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_bolts)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_state_spouts)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("StormTopology");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "spouts";
    field.Type = TType.Map;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Spouts.Count));
      foreach (string _iter34 in Spouts.Keys)
      {
        oprot.WriteString(_iter34);
        Spouts[_iter34].Write(oprot);
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "bolts";
    field.Type = TType.Map;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Bolts.Count));
      foreach (string _iter35 in Bolts.Keys)
      {
        oprot.WriteString(_iter35);
        Bolts[_iter35].Write(oprot);
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "state_spouts";
    field.Type = TType.Map;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, State_spouts.Count));
      foreach (string _iter36 in State_spouts.Keys)
      {
        oprot.WriteString(_iter36);
        State_spouts[_iter36].Write(oprot);
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("StormTopology(");
    __sb.Append(", Spouts: ");
    __sb.Append(Spouts);
    __sb.Append(", Bolts: ");
    __sb.Append(Bolts);
    __sb.Append(", State_spouts: ");
    __sb.Append(State_spouts);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif