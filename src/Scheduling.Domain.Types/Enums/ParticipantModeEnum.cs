using NhsWales.CommunityCommon.Domain.Types.Converters;
using NhsWales.CommunityCommon.Domain.Types.Enumeration;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NhsWales.Scheduling.Domain.Types.Enums;
[JsonConverter(typeof(LookupJsonConverter<string>))]
[TypeConverter(typeof(LookupTypeConverter<string, ParticipationModeEnum>))]
public record ParticipationModeEnum : Lookup<string>
{
    public ParticipationModeEnum(string id, string code, string description)
        : base(id, code, description)
    {
    }

    public static readonly ParticipationModeEnum FaceToFace = new("face-to-face", "faceToFace", "Participation by direct action where subject and actor are in the same location.");
    public static readonly ParticipationModeEnum Phone = new("phone", "phone", "Participation by voice communication where parties are separated.");
    public static readonly ParticipationModeEnum Videoconference = new("videoconference", "Videoconference", "Participation by real-time video and audio communication.");
    public static readonly ParticipationModeEnum Written = new("written", "written", "Participation by exchanging written messages.");
    public static readonly ParticipationModeEnum Email = new("email", "email", "Participation through electronic mail.");
    public static readonly ParticipationModeEnum TextMessage = new("text-message", "textMessage", "Participation via short message service (SMS).");
    public static readonly ParticipationModeEnum OnlineChat = new("online-chat", "onlineChat", "Participation via live online text-based chat.");
    public static readonly ParticipationModeEnum Data = new("data", "data", "Participation through data exchange or information system interaction.");
}