﻿using System;

namespace DynamicReport.Report
{
    /// <summary>
    /// Represent single field in Report.
    /// </summary>
    public interface IReportField
    {
        /// <summary>
        /// Field title in report.
        /// Example: "Full Name"
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Part of SQL query, describes report field data source.
        /// </summary>
        string SqlValueExpression { get; }

        /// <summary>
        /// Sql alias which will be used for current field. 
        /// Example: Select (p.FirstName + p.LastName) as fullName From ...
        /// </summary>
        string SqlAlias { get; }

        /// <summary>
        /// This transformation will be applied on current field value before it will be passed to client.
        /// Allow to apply any custom transformation, examples: 
        /// 1. Format data from DB format to customer format
        /// 2. Apply any calculation
        /// 3. Obfuscate or Encrypt sensitive data
        /// 4. Other usages...
        /// </summary>
        Func<string, string> OutputValueTransformation { get; }

        /// <summary>
        /// This transformation will be applied on user input before it will be used as filter value.
        /// Allow to apply any custom transformation, examples: 
        /// 1. Format data from customer format to DB format
        /// 2. Apply any calculation
        /// 3. Decrypt sensitive data
        /// 4. Other usages...
        /// </summary>
        Func<string, string> InputValueTransformation { get; }
    }
}