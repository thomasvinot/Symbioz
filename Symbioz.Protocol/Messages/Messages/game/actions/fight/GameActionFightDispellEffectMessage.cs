


















// Generated on 06/04/2015 18:44:06
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
{

public const ushort Id = 6113;
public override ushort MessageId
{
    get { return Id; }
}

public int boostUID;
        

public GameActionFightDispellEffectMessage()
{
}

public GameActionFightDispellEffectMessage(ushort actionId, int sourceId, int targetId, int boostUID)
         : base(actionId, sourceId, targetId)
        {
            this.boostUID = boostUID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(boostUID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            boostUID = reader.ReadInt();
            if (boostUID < 0)
                throw new Exception("Forbidden value on boostUID = " + boostUID + ", it doesn't respect the following condition : boostUID < 0");
            

}


}


}