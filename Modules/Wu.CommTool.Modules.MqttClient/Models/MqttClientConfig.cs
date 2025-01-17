﻿using Newtonsoft.Json;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using Wu.CommTool.Shared.Enums;
using Wu.CommTool.Shared.Enums.Mqtt;

namespace Wu.CommTool.Modules.MqttClient.Models
{
    public class MqttClientConfig : BindableBase
    {
        /// <summary>
        /// 客户端ID
        /// </summary>
        public string ClientId { get => _ClientId; set => SetProperty(ref _ClientId, value); }
        private string _ClientId = "ClientId";

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get => _UserName; set => SetProperty(ref _UserName, value); }
        private string _UserName = "UserName";

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get => _Password; set => SetProperty(ref _Password, value); }
        private string _Password = "Password";

        /// <summary>
        /// 订阅的主题
        /// </summary>
        public ObservableCollection<MqttTopic> SubscribeTopics { get => _SubscribeTopics; set => SetProperty(ref _SubscribeTopics, value); }
        private ObservableCollection<MqttTopic> _SubscribeTopics = new();

        /// <summary>
        /// 成功订阅的主题
        /// </summary>
        [JsonIgnore]
        public ObservableCollection<string> SubscribeSucceeds { get => _SubscribeSucceeds; set => SetProperty(ref _SubscribeSucceeds, value); }
        private ObservableCollection<string> _SubscribeSucceeds = new();

        /// <summary>
        /// 发布的主题
        /// </summary>
        public string PublishTopic { get => _PublishTopic; set => SetProperty(ref _PublishTopic, value); }
        private string _PublishTopic = string.Empty;

        /// <summary>
        /// 消息质量等级
        /// </summary>
        public QosLevel QosLevel { get => _QosLevel; set => SetProperty(ref _QosLevel, value); }
        private QosLevel _QosLevel = QosLevel.AtMostOnce;

        /// <summary>
        /// 是否为保留消息
        /// </summary>
        public bool IsRetain { get => _IsRetain; set => SetProperty(ref _IsRetain, value); }
        private bool _IsRetain;

        /// <summary>
        /// IP
        /// </summary>
        public string ServerIp { get => _ServerIp; set => SetProperty(ref _ServerIp, value); }
        private string _ServerIp = "192.168.1.10";

        /// <summary>
        /// 端口
        /// </summary>
        public int ServerPort { get => _ServerPort; set => SetProperty(ref _ServerPort, value); }
        private int _ServerPort = 1883;

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonIgnore]
        public bool IsOpened { get => _IsOpened; set => SetProperty(ref _IsOpened, value); }
        private bool _IsOpened = false;

        /// <summary>
        /// 自动重新连接
        /// </summary>
        public bool AutoReconnect { get => _AutoReconnect; set => SetProperty(ref _AutoReconnect, value); }
        private bool _AutoReconnect;


        /// <summary>
        /// 接收消息的格式
        /// </summary>
        public MqttPayloadType ReceivePaylodType { get => _ReceivePaylodType; set => SetProperty(ref _ReceivePaylodType, value); }
        private MqttPayloadType _ReceivePaylodType = MqttPayloadType.Plaintext;

        /// <summary>
        /// 发送消息的格式
        /// </summary>
        public MqttPayloadType SendPaylodType { get => _SendPaylodType; set => SetProperty(ref _SendPaylodType, value); }
        private MqttPayloadType _SendPaylodType = MqttPayloadType.Plaintext;
    }
}
