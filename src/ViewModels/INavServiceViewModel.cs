// Copyright (c) Richasy. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Richasy.WinUI.Share.ViewModels;

/// <summary>
/// 导航服务视图模型.
/// </summary>
public interface INavServiceViewModel
{
    /// <summary>
    /// 导航到指定页面.
    /// </summary>
    void NavigateTo([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type pageType, object? parameter = default);

    /// <summary>
    /// 导航到覆盖页面.
    /// </summary>
    void NavigateToOver([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type pageKey, object? parameter = default);
}
