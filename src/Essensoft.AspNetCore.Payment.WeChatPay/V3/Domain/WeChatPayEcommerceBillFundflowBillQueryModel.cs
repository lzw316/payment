﻿using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 账单 - 申请二级商户资金账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_5.shtml">账单 - 申请二级商户资金账单API</a> - 最新更新时间：2020.08.10</para>
    /// </remarks>
    public class WeChatPayEcommerceBillFundflowBillQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 账单日期
        /// </summary>
        /// <remarks>
        /// 格式YYYY-MM-DD
        /// 仅支持三个月内的账单下载申请。
        /// 示例值：2019-06-11
        /// </remarks>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 资金账户类型
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// ALL：所有账户
        /// 示例值：ALL
        /// </remarks>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 压缩类型
        /// </summary>
        /// <remarks>
        /// 不填则以不压缩的方式返回数据流，枚举值：
        /// GZIP：GZIP格式压缩
        /// 示例值：GZIP
        /// </remarks>
        [JsonPropertyName("tar_type")]
        public string TarType { get; set; }

        /// <summary>
        /// 加密算法
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// AEAD_AES_256_GCM：AEAD_AES_256_GCM加密算法
        /// 示例值：AEAD_AES_256_GCM
        /// </remarks>
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }
    }
}
