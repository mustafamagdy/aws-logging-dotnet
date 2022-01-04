using System.IO;
using Serilog.Events;
using Serilog.Formatting;

namespace AWS.Logger.SeriLog
{
  /// <summary>
  /// Default class for aws cloudwatch log text formatter
  /// </summary>
  public class DefaultAWSCloudWatchTextFormatter : ITextFormatter
  {
    /// <summary>
    /// Format the message written to cloudwatch logs
    /// </summary>
    /// <param name="logEvent"></param>
    /// <param name="output"></param>
    public void Format(LogEvent logEvent, TextWriter output)
    {
      output.Write("{0}|{1}| {2} {3}", logEvent.Timestamp, logEvent.Level, logEvent.MessageTemplate, output.NewLine);
      if (logEvent.Exception != null)
      {
        output.Write("Exception - {0}", logEvent.Exception);
      }
    }
  }
}