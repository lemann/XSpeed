﻿using System.Runtime.InteropServices;

namespace QuantBox.CSharp2XSpeed
{
    /// <summary>
    /// 心跳包
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCTimeOutField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;

    };

    /// <summary>
    /// 请求报单数据类型(基本报单)
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCInsertOrderField
    {
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 本地委托号, 由API使用者维护，在同一个会话中不能重复
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 合约代码, 支持目前国内4个期货交易所的所有合约，包括大商所/郑商所的套利合约
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 报单价格, 当报单类型为市价时，该字段不起作用
        /// </summary>
        public double insertPrice;
        /// <summary>
        /// 报单数量
        /// </summary>
        public int orderAmount;
        /// <summary>
        /// 买卖标志
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平标志
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 投保类型, 支持投机、套利、套保
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 委托类别(默认为普通订单)
        /// </summary>
        public DFITCInsertType insertType;
        /// <summary>
        /// 报单类型, 支持限价 、市价；上期所合约不支持市价，均按限价进行处理
        /// </summary>
        public DFITCOrderTypeType orderType;
        /// <summary>
        /// 报单附加属性, 支持None、FAK、FOK，目前只有大商所合约支持该报单附加属性 FAK/FOK
        /// </summary>
        public DFITCOrderPropertyType orderProperty;
        /// <summary>
        /// 合约类型, 可选值：期货、期权， 目前只支持期货。
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 撤单数据类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCCancelOrderField
    {
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;

    };

    /// <summary>
    /// 委托响应类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCOrderRspDataRtnField
    {
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 委托状态
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCOrderAnswerStatusType orderStatus;
    };

    /// <summary>
    /// 查询资金数据类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCCapitalField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
    };

    /// <summary>
    /// 查询持仓数据类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCPositionField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 交易所合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCExchangeInstrumentField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 交易所编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 用户登录数据类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCUserLoginField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string passwd;
        /// <summary>
        /// 厂商ID
        /// </summary>
        public short companyID;
    };

    /// <summary>
    /// 用户退出类型
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCUserLogoutField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金帐号ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 会话ID
        /// </summary>
        public int sessionID;
    };

    /// <summary>
    /// 委托回报
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCOrderRtnField
    {
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string OrderSysID;
        /// <summary>
        /// 委托状态
        /// </summary>
        public DFITCOrderAnswerStatusType orderStatus;
        /// <summary>
        /// 会话ID
        /// </summary>
        public int sessionID;
        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string SuspendTime;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 交易所编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 投资类别
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 委托价
        /// </summary>
        public double insertPrice;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int cancelAmount;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int orderAmount;
        /// <summary>
        /// 委托类别
        /// </summary>
        public DFITCInsertType insertType;
        /// <summary>
        /// 预留字段1
        /// </summary>
        public int reservedType1;
        /// <summary>
        /// 预留字段2
        /// </summary>
        public int reservedType2;
    };

    /// <summary>
    /// 成交回报
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCMatchRtnField
    {
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string OrderSysID;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string matchID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平标志
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 成交价格
        /// </summary>
        public double matchedPrice;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int orderAmount;
        /// <summary>
        /// 成交数量
        /// </summary>
        public int matchedAmount;
        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string matchedTime;
        /// <summary>
        /// 报价
        /// </summary>
        public double insertPrice;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 成交类型
        /// </summary>
        public DFITCMatchType matchType;
        /// <summary>
        /// 投保
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 交易所ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 手续费
        /// </summary>
        public double fee;
        /// <summary>
        /// 会话ID
        /// </summary>
        public int sessionID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 委托状态
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCOrderAnswerStatusType orderStatus;
        /// <summary>
        /// 预留字段1
        /// </summary>
        public int reservedType1;
        /// <summary>
        /// 预留字段2
        /// </summary>
        public int reservedType2;
    };

    /// <summary>
    /// 撤单回报
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCOrderCanceledRtnField
    {
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string OrderSysID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 报单价格
        /// </summary>
        public double insertPrice;
        /// <summary>
        /// 买卖类型
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平标志
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int cancelAmount;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 投保
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 交易所ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string canceledTime;
        /// <summary>
        /// 会话ID
        /// </summary>
        public int sessionID;
        /// <summary>
        /// 委托状态
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCOrderAnswerStatusType orderStatus;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int orderAmount;
    };

    /// <summary>
    /// 错误信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCErrorRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int requestID;
        /// <summary>
        /// 会话标识
        /// </summary>
        public int sessionID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 错误ID
        /// </summary>
        public int nErrorID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string errorMsg;
    };

    /// <summary>
    /// 返回资金信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCCapitalInfoRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int requestID;
        /// <summary>
        /// 资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 上日权益
        /// </summary>
        public double preEquity;
        /// <summary>
        /// 当日客户权益
        /// </summary>
        public double todayEquity;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double closeProfitLoss;
        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double positionProfitLoss;
        /// <summary>
        /// 委托冻结保证金
        /// </summary>
        public double frozenMargin;
        /// <summary>
        /// 持仓保证金
        /// </summary>
        public double margin;
        /// <summary>
        /// 当日手续费
        /// </summary>
        public double fee;
        /// <summary>
        /// 可用资金
        /// </summary>
        public double available;
        /// <summary>
        /// 可取资金
        /// </summary>
        public double withdraw;
        /// <summary>
        /// 风险度
        /// </summary>
        public double riskDegree;
        /// <summary>
        /// 本日权利金收入
        /// </summary>
        public double todayPremiumIncome;
        /// <summary>
        /// 本日权利金付出
        /// </summary>
        public double todayPremiumPay;
        /// <summary>
        /// 昨权利金收付
        /// </summary>
        public double yesterdayPremium;
        /// <summary>
        /// 期权市值
        /// </summary>
        public double optMarketValue;
    };

    /// <summary>
    /// 返回持仓信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCPositionInfoRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金帐号ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开仓均价
        /// </summary>
        public double openAvgPrice;
        /// <summary>
        /// 持仓均价
        /// </summary>
        public double positionAvgPrice;
        /// <summary>
        /// 持仓量
        /// </summary>
        public int positionAmount;
        /// <summary>
        /// 总可用
        /// </summary>
        public int totalAvaiAmount;
        /// <summary>
        /// 今可用
        /// </summary>
        public int todayAvaiAmount;
        /// <summary>
        /// 昨可用
        /// </summary>
        public int lastAvaiAmount;
        /// <summary>
        /// 今仓
        /// </summary>
        public int todayAmount;
        /// <summary>
        /// 昨仓
        /// </summary>
        public int lastAmount;
        /// <summary>
        /// 挂单量
        /// </summary>
        public int tradingAmount;
        /// <summary>
        /// 盯市持仓盈亏
        /// </summary>
        public double datePositionProfitLoss;
        /// <summary>
        /// 盯市平仓盈亏
        /// </summary>
        public double dateCloseProfitLoss;
        /// <summary>
        /// 权利金
        /// </summary>
        public double dPremium;
        /// <summary>
        /// 浮动盈亏
        /// </summary>
        public double floatProfitLoss;
        /// <summary>
        /// 占用保证金
        /// </summary>
        public double dMargin;
        /// <summary>
        /// 投保类别
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string clientID;
        /// <summary>
        /// 昨结算价
        /// </summary>
        public double lastPrice;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 用户登录返回信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCUserLoginInfoRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金帐号ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 登录结果
        /// </summary>
        public int loginResult;
        /// <summary>
        /// 初始本地委托号
        /// </summary>
        public int initLocalOrderID;
        /// <summary>
        /// sessionID
        /// </summary>
        public int sessionID;
        /// <summary>
        /// 错误ID
        /// </summary>
        public int nErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string errorMsg;
        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string DCEtime;
        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string SHFETime;
        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string CFFEXTime;
        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string CZCETime;
    };

    /// <summary>
    /// 用户退出返回信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCUserLogoutInfoRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int requestID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 退出结果
        /// </summary>
        public int logoutResult;
        /// <summary>
        /// 错误ID
        /// </summary>
        public int nErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string errorMsg;
    };

    /// <summary>
    /// 套利合约查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCAbiInstrumentField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;

    };

    /// <summary>
    /// 套利合约返回信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCAbiInstrumentRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 交易所编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 品种名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string instrumentName;
    };

    /// <summary>
    /// 指定的合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCSpecificInstrumentField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账户ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 交易所ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 行情订阅返回信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCActiveContractField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 有效合约
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string activeContract;
    };

    /// <summary>
    /// 交易所合约返回信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCExchangeInstrumentRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 交易所编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 品种名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string VarietyName;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 委托上限
        /// </summary>
        public int orderTopLimit;
        /// <summary>
        /// 合约乘数
        /// </summary>
        public double contractMultiplier;
        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double minPriceFluctuation;
    };

    /// <summary>
    /// 委托查询数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCOrderField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int requestID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 成交查询数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCMatchField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int requestID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 委托查询响应数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCOrderCommRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 委托状态
        /// </summary>
        public DFITCOrderAnswerStatusType orderStatus;
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平标志
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 委托价
        /// </summary>
        public double insertPrice;
        /// <summary>
        /// 委托数量
        /// </summary>
        public int orderAmount;
        /// <summary>
        /// 成交价格
        /// </summary>
        public double matchedPrice;
        /// <summary>
        /// 成交数量
        /// </summary>
        public int matchedAmount;
        /// <summary>
        /// 撤单数量
        /// </summary>
        public int cancelAmount;
        /// <summary>
        /// 委托单类别
        /// </summary>
        public DFITCInsertType insertType;
        /// <summary>
        /// 投保
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string commTime;
        /// <summary>
        /// 申报时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string submitTime;
        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string clientID;
        /// <summary>
        /// 交易所ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 委托地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string operStation;
        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 预留字段1
        /// </summary>
        public int reservedType1;
        /// <summary>
        /// 预留字段2
        /// </summary>
        public int reservedType2;
    };

    /// <summary>
    /// 成交查询数据响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCMatchedRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 柜台委托号
        /// </summary>
        public int spdOrderID;
        /// <summary>
        /// 交易所编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开平
        /// </summary>
        public DFITCOpenCloseTypeType openCloseType;
        /// <summary>
        /// 成交价格
        /// </summary>
        public double matchedPrice;
        /// <summary>
        /// 成交数量
        /// </summary>
        public int matchedAmount;
        /// <summary>
        /// 成交金额
        /// </summary>
        public double matchedMort;
        /// <summary>
        /// 投保类别
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string matchedTime;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string matchedID;
        /// <summary>
        /// 本地委托号
        /// </summary>
        public int localOrderID;
        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string clientID;
        /// <summary>
        /// 成交类型
        /// </summary>
        public DFITCMatchType matchType;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
        /// <summary>
        /// 预留字段1
        /// </summary>
        public int reservedType1;
        /// <summary>
        /// 预留字段2
        /// </summary>
        public int reservedType2;
    };

    /// <summary>
    /// 返回合约信息数据结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCInstrumentRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double longMarginRatio;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double shortMarginRatio;
        /// <summary>
        /// 开仓手续费 按手数计算
        /// </summary>
        public double openFeeVolRatio;
        /// <summary>
        /// 平仓手续费 按手数计算
        /// </summary>
        public double closeFeeVolRatio;
        /// <summary>
        /// 平今手续费 按手数计算
        /// </summary>
        public double closeTodayFeeVolRatio;
        /// <summary>
        /// 开仓手续费率 按金额计算
        /// </summary>
        public double openFeeAmtRatio;
        /// <summary>
        /// 平仓手续费率 按金额计算
        /// </summary>
        public double closeFeeAmtRatio;
        /// <summary>
        /// 平今手续费率 按金额计算
        /// </summary>
        public double closeTodayFeeAmtRatio;
        /// <summary>
        /// 委托上限
        /// </summary>
        public int orderTopLimit;
        /// <summary>
        /// 合约乘数
        /// </summary>
        public double contractMultiplier;
        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double minimumPriceChange;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 深度行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCDepthMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string TradingDay;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string ExchangeInstID;
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;
        /// <summary>
        /// 昨持仓量
        /// </summary>
        public int PreOpenInterest;
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;
        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;
        /// <summary>
        /// 持仓量
        /// </summary>
        public int OpenInterest;
        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;
        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;
        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;
        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string UpdateTime;
        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;
        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;
        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;
        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;
        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;
        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;
        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;
        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;
        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;
        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;
        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;
        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;
        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;
        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;
        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;
        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;
        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;
        /// <summary>
        /// 柜台系统时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string XSpeedTime;
    };

    /// <summary>
    /// 查询持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCPositionDetailField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 查询持仓明细响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCPositionDetailRtnField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金帐号ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 买卖
        /// </summary>
        [MarshalAs(UnmanagedType.I2)]
        public DFITCBuySellTypeType buySellType;
        /// <summary>
        /// 开仓价
        /// </summary>
        public double openPrice;
        /// <summary>
        /// 手数
        /// </summary>
        public double volume;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string matchID;
        /// <summary>
        /// 成交日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string matchedData;
        /// <summary>
        /// 盯市持仓盈亏
        /// </summary>
        public double datePositionProfitLoss;
        /// <summary>
        /// 盯市平仓盈亏
        /// </summary>
        public double dateCloseProfitLoss;
        /// <summary>
        /// 浮动盈亏
        /// </summary>
        public double floatProfitLoss;
        /// <summary>
        /// 占用保证金
        /// </summary>
        public double dMargin;
        /// <summary>
        /// 投保类别
        /// </summary>
        public DFITCSpeculatorType speculator;
        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string clientID;
        /// <summary>
        /// 昨结算价
        /// </summary>
        public double lastPrice;
        /// <summary>
        /// 合约类型
        /// </summary>
        public DFITCInstrumentTypeType instrumentType;
    };

    /// <summary>
    /// 用户事件通知信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCTradingNoticeInfoField
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public int lRequestID;
        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string accountID;
        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string SendTime;
        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
        /// <summary>
        /// 消息类型
        /// </summary>
        public DFITCNoticeType noticeType;
    };

    /// <summary>
    /// 合约交易状态通知信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DFITCInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string InstrumentID;
        /// <summary>
        /// 合约交易状态
        /// </summary>
        public int InstrumentStatus;
        /// <summary>
        /// 交易阶段编号
        /// </summary>
        public int TradingSegmentSN;
        /// <summary>
        /// 进入本状态时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string EnterTime;
        /// <summary>
        /// 进入本状态原因
        /// </summary>
        public short EnterReason;
    };
}