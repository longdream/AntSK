﻿using System.ComponentModel;

namespace AntSK.Test
{
    /// <summary>
    /// 测试插件导入
    /// </summary>
    public class TestFunctionImport
    {
        [Description("AntSK")]
        public string GetName()
        {
            return $"""
                   我的名字是AntSK,
                   我的作者是许泽宇
                   我是一个AI 知识库/智能体项目
                """;
        }
    }
}