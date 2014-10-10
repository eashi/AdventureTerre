//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace AdventureTerreGrains.Grains
{
    using System.Collections.Generic;
    using System.Collections;
    using System.Runtime.Serialization;
    using System;
    using Orleans.CodeGeneration;
    using Orleans;
    using AdventureTerreInterfaces.GrainInterfaces;
    using System.Runtime.InteropServices;
    using Orleans.Runtime;
    using AdventureTerreInterfaces.Models;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("AdventureTerreGrains.Grains.AdventureTerreGrains.Grains.GameStateGrain")]
    public class GameStateGrainState : global::Orleans.CodeGeneration.GrainState, IGameState
    {
        

            public Dictionary<String,Boolean> gameState { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("gameState", out value)) gameState = (Dictionary<String,Boolean>) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("GameStateGrainState( gameState={0} )", gameState);
            }
        
        public GameStateGrainState() : 
                base("AdventureTerreGrains.Grains.GameStateGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["gameState"] = this.gameState;
            return result;
        }
        
        private void InitStateFields()
        {
            this.gameState = new Dictionary<String,Boolean>();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            GameStateGrainState input = ((GameStateGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            GameStateGrainState input = ((GameStateGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            GameStateGrainState result = new GameStateGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("AdventureTerreGrains.Grains.AdventureTerreGrains.Grains.MonsterGrain")]
    public class MonsterGrainState : global::Orleans.CodeGeneration.GrainState, IMonsterState
    {
        

            public IRoomGrain roomGrain { get; set; }

            public Guid playerGuid { get; set; }

            public IPlayerGrain playerGrain { get; set; }

            public MonsterInfo monsterInfo { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("roomGrain", out value)) roomGrain = (IRoomGrain) value;
                if (values.TryGetValue("playerGuid", out value)) playerGuid = (Guid) value;
                if (values.TryGetValue("playerGrain", out value)) playerGrain = (IPlayerGrain) value;
                if (values.TryGetValue("monsterInfo", out value)) monsterInfo = (MonsterInfo) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("MonsterGrainState( roomGrain={0} playerGuid={1} playerGrain={2} monsterInfo={3} )", roomGrain, playerGuid, playerGrain, monsterInfo);
            }
        
        public MonsterGrainState() : 
                base("AdventureTerreGrains.Grains.MonsterGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["roomGrain"] = this.roomGrain;
            result["playerGuid"] = this.playerGuid;
            result["playerGrain"] = this.playerGrain;
            result["monsterInfo"] = this.monsterInfo;
            return result;
        }
        
        private void InitStateFields()
        {
            this.roomGrain = default(IRoomGrain);
            this.playerGuid = default(Guid);
            this.playerGrain = default(IPlayerGrain);
            this.monsterInfo = new MonsterInfo();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            MonsterGrainState input = ((MonsterGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            MonsterGrainState input = ((MonsterGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            MonsterGrainState result = new MonsterGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("AdventureTerreGrains.Grains.AdventureTerreGrains.Grains.PlayerGrain")]
    public class PlayerGrainState : global::Orleans.CodeGeneration.GrainState, IPlayerState
    {
        

            public IRoomGrain roomGrain { get; set; }

            public List<Thing> things { get; set; }

            public List<IRoomGrain> roomGrains { get; set; }

            public List<IMonsterGrain> monsterGrains { get; set; }

            public List<INPCGrain> npcGrains { get; set; }

            public Boolean killed { get; set; }

            public PlayerInfo myInfo { get; set; }

            public List<String> playerHistory { get; set; }

            public IGameStateGrain gameState { get; set; }

            public Int32 version { get; set; }

            public List<StateChangeAction> stateChangeActions { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("roomGrain", out value)) roomGrain = (IRoomGrain) value;
                if (values.TryGetValue("things", out value)) things = (List<Thing>) value;
                if (values.TryGetValue("roomGrains", out value)) roomGrains = (List<IRoomGrain>) value;
                if (values.TryGetValue("monsterGrains", out value)) monsterGrains = (List<IMonsterGrain>) value;
                if (values.TryGetValue("npcGrains", out value)) npcGrains = (List<INPCGrain>) value;
                if (values.TryGetValue("killed", out value)) killed = (Boolean) value;
                if (values.TryGetValue("myInfo", out value)) myInfo = (PlayerInfo) value;
                if (values.TryGetValue("playerHistory", out value)) playerHistory = (List<String>) value;
                if (values.TryGetValue("gameState", out value)) gameState = (IGameStateGrain) value;
                if (values.TryGetValue("version", out value)) version = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("stateChangeActions", out value)) stateChangeActions = (List<StateChangeAction>) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PlayerGrainState( roomGrain={0} things={1} roomGrains={2} monsterGrains={3} npcGrains={4} killed={5} myInfo={6} playerHistory={7} gameState={8} version={9} stateChangeActions={10} )", roomGrain, things, roomGrains, monsterGrains, npcGrains, killed, myInfo, playerHistory, gameState, version, stateChangeActions);
            }
        
        public PlayerGrainState() : 
                base("AdventureTerreGrains.Grains.PlayerGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["roomGrain"] = this.roomGrain;
            result["things"] = this.things;
            result["roomGrains"] = this.roomGrains;
            result["monsterGrains"] = this.monsterGrains;
            result["npcGrains"] = this.npcGrains;
            result["killed"] = this.killed;
            result["myInfo"] = this.myInfo;
            result["playerHistory"] = this.playerHistory;
            result["gameState"] = this.gameState;
            result["version"] = this.version;
            result["stateChangeActions"] = this.stateChangeActions;
            return result;
        }
        
        private void InitStateFields()
        {
            this.roomGrain = default(IRoomGrain);
            this.things = new List<Thing>();
            this.roomGrains = new List<IRoomGrain>();
            this.monsterGrains = new List<IMonsterGrain>();
            this.npcGrains = new List<INPCGrain>();
            this.killed = default(Boolean);
            this.myInfo = new PlayerInfo();
            this.playerHistory = new List<String>();
            this.gameState = default(IGameStateGrain);
            this.version = default(Int32);
            this.stateChangeActions = new List<StateChangeAction>();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PlayerGrainState input = ((PlayerGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PlayerGrainState input = ((PlayerGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PlayerGrainState result = new PlayerGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("AdventureTerreGrains.Grains.AdventureTerreGrains.Grains.RoomGrain")]
    public class RoomGrainState : global::Orleans.CodeGeneration.GrainState, IRoomState
    {
        

            public Int64 roomId { get; set; }

            public String name { get; set; }

            public List<IPlayerGrain> players { get; set; }

            public List<IMonsterGrain> monsters { get; set; }

            public List<Thing> things { get; set; }

            public List<INPCGrain> npcs { get; set; }

            public List<Descriptor> descriptors { get; set; }

            public List<Direction> directions { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("roomId", out value)) roomId = value is Int32 ? (Int32)value : (Int64)value;
                if (values.TryGetValue("name", out value)) name = (String) value;
                if (values.TryGetValue("players", out value)) players = (List<IPlayerGrain>) value;
                if (values.TryGetValue("monsters", out value)) monsters = (List<IMonsterGrain>) value;
                if (values.TryGetValue("things", out value)) things = (List<Thing>) value;
                if (values.TryGetValue("npcs", out value)) npcs = (List<INPCGrain>) value;
                if (values.TryGetValue("descriptors", out value)) descriptors = (List<Descriptor>) value;
                if (values.TryGetValue("directions", out value)) directions = (List<Direction>) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("RoomGrainState( roomId={0} name={1} players={2} monsters={3} things={4} npcs={5} descriptors={6} directions={7} )", roomId, name, players, monsters, things, npcs, descriptors, directions);
            }
        
        public RoomGrainState() : 
                base("AdventureTerreGrains.Grains.RoomGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["roomId"] = this.roomId;
            result["name"] = this.name;
            result["players"] = this.players;
            result["monsters"] = this.monsters;
            result["things"] = this.things;
            result["npcs"] = this.npcs;
            result["descriptors"] = this.descriptors;
            result["directions"] = this.directions;
            return result;
        }
        
        private void InitStateFields()
        {
            this.roomId = default(Int64);
            this.name = default(String);
            this.players = new List<IPlayerGrain>();
            this.monsters = new List<IMonsterGrain>();
            this.things = new List<Thing>();
            this.npcs = new List<INPCGrain>();
            this.descriptors = new List<Descriptor>();
            this.directions = new List<Direction>();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            RoomGrainState input = ((RoomGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            RoomGrainState input = ((RoomGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            RoomGrainState result = new RoomGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
namespace AdventureTerreGrains
{
    using AdventureTerreInterfaces.GrainInterfaces;
    using Orleans;
    using Orleans.Runtime;
    using System;
    using AdventureTerreInterfaces.Models;
    using Orleans.CodeGeneration;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("AdventureTerreGrains.AdventureTerreGrains.NPCGrain")]
    public class NPCGrainState : global::Orleans.CodeGeneration.GrainState, INPCState
    {
        

            public IRoomGrain roomGrain { get; set; }

            public Guid playerGuid { get; set; }

            public IPlayerGrain playerGrain { get; set; }

            public NPCInfo npcInfo { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("roomGrain", out value)) roomGrain = (IRoomGrain) value;
                if (values.TryGetValue("playerGuid", out value)) playerGuid = (Guid) value;
                if (values.TryGetValue("playerGrain", out value)) playerGrain = (IPlayerGrain) value;
                if (values.TryGetValue("npcInfo", out value)) npcInfo = (NPCInfo) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("NPCGrainState( roomGrain={0} playerGuid={1} playerGrain={2} npcInfo={3} )", roomGrain, playerGuid, playerGrain, npcInfo);
            }
        
        public NPCGrainState() : 
                base("AdventureTerreGrains.NPCGrain")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["roomGrain"] = this.roomGrain;
            result["playerGuid"] = this.playerGuid;
            result["playerGrain"] = this.playerGrain;
            result["npcInfo"] = this.npcInfo;
            return result;
        }
        
        private void InitStateFields()
        {
            this.roomGrain = default(IRoomGrain);
            this.playerGuid = default(Guid);
            this.playerGrain = default(IPlayerGrain);
            this.npcInfo = new NPCInfo();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            NPCGrainState input = ((NPCGrainState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            NPCGrainState input = ((NPCGrainState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            NPCGrainState result = new NPCGrainState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
