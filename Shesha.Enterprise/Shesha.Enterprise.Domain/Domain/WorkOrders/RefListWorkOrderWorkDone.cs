using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.WorkOrders
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "WorkOrderWorkDone")]
    public enum RefListWorkOrderWorkDone : long
    {
        /// <summary>
        /// ReplacementOfASplitMeter
        /// </summary>
        [Description("ReplacementOfASplitMeter")]
        ReplacementOfASplitMeter = 1,

        /// <summary>
        /// SplitMeterConversion
        /// </summary>
        [Description("SplitMeterConversion")]
        SplitMeterConversion = 2,

        /// <summary>
        /// CreditToPrepaidMeterRetrofit
        /// </summary>
        [Description("CreditToPrepaidMeterRetrofit")]
        CreditToPrepaidMeterRetrofit = 4,

        /// <summary>
        /// KeypadReplacementWiredCommsWires
        /// </summary>
        [Description("KeypadReplacementWiredCommsWires")]
        KeypadReplacementWiredCommsWires = 8,

        /// <summary>
        /// KeypadReplacementPLCSMART
        /// </summary>
        [Description("KeypadReplacementPLCSMART")]
        KeypadReplacementPLCSMART = 16,

        /// <summary>
        /// MeterReplacementsSinglePhase
        /// </summary>
        [Description("MeterReplacementsSinglePhase")]
        MeterReplacementsSinglePhase = 32,

        /// <summary>
        /// MeterReplacementsThreePhase
        /// </summary>
        [Description("MeterReplacementsThreePhase")]
        MeterReplacementsThreePhase = 64,

        /// <summary>
        /// ReplacementOfAFuseBaseAndCarrierWithSimilarOrCircuitBreaker
        /// </summary>
        [Description("ReplacementOfAFuseBaseAndCarrierWithSimilarOrCircuitBreaker")]
        ReplacementOfAFuseBaseAndCarrierWithSimilarOrCircuitBreaker = 128,

        /// <summary>
        /// PLCMeterChanges
        /// </summary>
        [Description("PLCMeterChanges")]
        PLCMeterChanges = 256,

        /// <summary>
        /// Inspection
        /// </summary>
        [Description("Inspection")]
        Inspection = 512,

        /// <summary>
        /// ServiceCableRemovalSCR
        /// </summary>
        [Description("ServiceCableRemovalSCR")]
        ServiceCableRemovalSCR = 1024,

        /// <summary>
        /// RemoveAllGearRAG
        /// </summary>
        [Description("RemoveAllGearRAG")]
        RemoveAllGearRAG = 2048,

        /// <summary>
        /// RemoveMeter
        /// </summary>
        [Description("RemoveMeter")]
        RemoveMeter = 4096,

        /// <summary>
        /// ReconnectionOHM
        /// </summary>
        [Description("ReconnectionOHM")]
        ReconnectionOHM = 8192,

        /// <summary>
        /// ReconnectionUGM
        /// </summary>
        [Description("ReconnectionUGM")]
        ReconnectionUGM = 16384,

        /// <summary>
        /// NormalReconnectionSingleOrThreePhase
        /// </summary>
        [Description("NormalReconnectionSingleOrThreePhase")]
        NormalReconnectionSingleOrThreePhase = 32768,

        /// <summary>
        /// HardReconnectionAtCDUSinglePhase
        /// </summary>
        [Description("HardReconnectionAtCDUSinglePhase")]
        HardReconnectionAtCDUSinglePhase = 65536,

        /// <summary>
        /// HardReconnectionAtCDUThreePhase
        /// </summary>
        [Description("HardReconnectionAtCDUThreePhase")]
        HardReconnectionAtCDUThreePhase = 131072,

        /// <summary>
        /// HardReconnectionAtThePoleSinglePhase
        /// </summary>
        [Description("HardReconnectionAtThePoleSinglePhase")]
        HardReconnectionAtThePoleSinglePhase = 262144,

        /// <summary>
        /// HardReconnectionAtThePoleThreePhase
        /// </summary>
        [Description("HardReconnectionAtThePoleThreePhase")]
        HardReconnectionAtThePoleThreePhase = 524288,

        /// <summary>
        /// DisconnectionOHM
        /// </summary>
        [Description("DisconnectionOHM")]
        DisconnectionOHM = 1048576,

        /// <summary>
        /// DisconnectionUGM
        /// </summary>
        [Description("DisconnectionUGM")]
        DisconnectionUGM = 2097152,

        /// <summary>
        /// NormalDisconnectionSingleOrThreePhase
        /// </summary>
        [Description("NormalDisconnectionSingleOrThreePhase")]
        NormalDisconnectionSingleOrThreePhase = 4194304,

        /// <summary>
        /// HardDisconnectionAtCDUSinglePhase
        /// </summary>
        [Description("HardDisconnectionAtCDUSinglePhase")]
        HardDisconnectionAtCDUSinglePhase = 8388608,

        /// <summary>
        /// HardDisconnectionAtCDUThreePhase
        /// </summary>
        [Description("HardDisconnectionAtCDUThreePhase")]
        HardDisconnectionAtCDUThreePhase = 16777216,

        /// <summary>
        /// HardDisconnectionAtThePoleSinglePhase
        /// </summary>
        [Description("HardDisconnectionAtThePoleSinglePhase")]
        HardDisconnectionAtThePoleSinglePhase = 33554432,

        /// <summary>
        /// HardDisconnectionAtThePoleThreePhase
        /// </summary>
        [Description("HardDisconnectionAtThePoleThreePhase")]
        HardDisconnectionAtThePoleThreePhase = 67108864,

        /// <summary>
        /// SpecialHardDisconnection
        /// </summary>
        [Description("SpecialHardDisconnection")]
        SpecialHardDisconnection = 134217728,

        /// <summary>
        /// KEYPAD Replacement (wired)
        /// </summary>
        [Description("KEYPAD Replacement (wired)")]
        KEYPADReplacementWired = 268435456,

        /// <summary>
        /// KEYPAD Replacement (PLC)
        /// </summary>
        [Description("KEYPAD Replacement (PLC)")]
        KEYPADReplacementPLC = 536870912,

        /// <summary>
        /// Remove P/P Meter
        /// </summary>
        [Description("Remove P/P Meter")]
        RemovePPMeter = 1073741824,

        /// <summary>
        /// Remove Cr Meter
        /// </summary>
        [Description("Remove Cr Meter")]
        RemoveCrMeter = 2147483648,

        /// <summary>
        /// Remove Bypass
        /// </summary>
        [Description("Remove Bypass")]
        RemoveBypass = 4294967296
    }
}