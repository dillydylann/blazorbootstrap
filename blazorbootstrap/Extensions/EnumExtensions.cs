﻿namespace BlazorBootstrap;

/// <summary>
/// Enum extensions
/// Pattern matching: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching
/// Discard pattern: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#discard-pattern
/// </summary>
public static class EnumExtensions
{
    #region Methods

    public static string ToAlertColorClass(this AlertColor color) =>
        color switch
        {
            AlertColor.Primary => "alert-primary",
            AlertColor.Secondary => "alert-secondary",
            AlertColor.Success => "alert-success",
            AlertColor.Danger => "alert-danger",
            AlertColor.Warning => "alert-warning",
            AlertColor.Info => "alert-info",
            AlertColor.Light => "alert-light",
            AlertColor.Dark => "alert-dark",
            _ => ""
        };

    public static string ToAutoCompleteSizeClass(this AutoCompleteSize size) =>
        size switch
        {
            AutoCompleteSize.Large => "form-control-lg",
            AutoCompleteSize.Small => "form-control-sm",
            _ => ""
        };

    public static string ToBackgroundAndTextClass(this BackgroundColor backgroundColor) =>
        backgroundColor switch
        {
            BackgroundColor.Primary => "bg-primary text-white",
            BackgroundColor.Secondary => "bg-secondary text-white",
            BackgroundColor.Success => "bg-success text-white",
            BackgroundColor.Danger => "bg-danger text-white",
            BackgroundColor.Warning => "bg-warning text-dark",
            BackgroundColor.Info => "bg-info text-dark",
            BackgroundColor.Light => "bg-light text-dark",
            BackgroundColor.Dark => "bg-dark text-white",
            BackgroundColor.Body => "bg-body text-dark",
            BackgroundColor.White => "bg-white text-dark",
            BackgroundColor.Transparent => "bg-transparent text-dark",
            _ => ""
        };

    public static string ToBackgroundClass(this BackgroundColor backgroundColor) =>
        backgroundColor switch
        {
            BackgroundColor.Primary => "bg-primary",
            BackgroundColor.Secondary => "bg-secondary",
            BackgroundColor.Success => "bg-success",
            BackgroundColor.Danger => "bg-danger",
            BackgroundColor.Warning => "bg-warning",
            BackgroundColor.Info => "bg-info",
            BackgroundColor.Light => "bg-light",
            BackgroundColor.Dark => "bg-dark",
            BackgroundColor.Body => "bg-body",
            BackgroundColor.White => "bg-white",
            BackgroundColor.Transparent => "bg-transparent",
            _ => ""
        };

    public static string ToBadgeColorClass(this BadgeColor color) =>
        color switch
        {
            BadgeColor.Primary => "text-bg-primary",
            BadgeColor.Secondary => "text-bg-secondary",
            BadgeColor.Success => "text-bg-success",
            BadgeColor.Danger => "text-bg-danger",
            BadgeColor.Warning => "text-bg-warning",
            BadgeColor.Info => "text-bg-info",
            BadgeColor.Light => "text-bg-light",
            BadgeColor.Dark => "text-bg-dark",
            _ => ""
        };

    public static string ToBadgeIndicatorClass(this BadgeIndicatorType indicatorType) =>
        indicatorType switch
        {
            BadgeIndicatorType.RoundedPill => "rounded-pill",
            BadgeIndicatorType.RoundedCircle => "rounded-circle",
            _ => "" // default: Top right
        };

    public static string ToBadgePlacementClass(this BadgePlacement badgePlacement) =>
        badgePlacement switch
        {
            BadgePlacement.TopLeft => "top-0 start-0 translate-middle",
            BadgePlacement.TopCenter => "top-0 start-50 translate-middle",
            BadgePlacement.TopRight => "top-0 start-100 translate-middle",
            BadgePlacement.MiddleLeft => "top-50 start-0 translate-middle",
            BadgePlacement.MiddleCenter => "top-50 start-50 translate-middle",
            BadgePlacement.MiddleRight => "top-50 start-100 translate-middle",
            BadgePlacement.BottomLeft => "top-100 start-0 translate-middle",
            BadgePlacement.BottomCenter => "top-100 start-50 translate-middle",
            BadgePlacement.BottomRight => "top-100 start-100 translate-middle",
            _ => "top-0 start-100 translate-middle" // default: Top right
        };

    public static string ToButtonColorClass(this ButtonColor buttonColor) =>
        buttonColor switch
        {
            ButtonColor.Primary => "btn-primary",
            ButtonColor.Secondary => "btn-secondary",
            ButtonColor.Success => "btn-success",
            ButtonColor.Danger => "btn-danger",
            ButtonColor.Warning => "btn-warning",
            ButtonColor.Info => "btn-info",
            ButtonColor.Light => "btn-light",
            ButtonColor.Dark => "btn-dark",
            ButtonColor.Link => "btn-link",
            _ => ""
        };

    public static string ToButtonOutlineColorClass(this ButtonColor color) =>
        color switch
        {
            ButtonColor.Primary => "btn-outline-primary",
            ButtonColor.Secondary => "btn-outline-secondary",
            ButtonColor.Success => "btn-outline-success",
            ButtonColor.Danger => "btn-outline-danger",
            ButtonColor.Warning => "btn-outline-warning",
            ButtonColor.Info => "btn-outline-info",
            ButtonColor.Light => "btn-outline-light",
            ButtonColor.Dark => "btn-outline-dark",
            ButtonColor.Link => "btn-outline-link",
            _ => ""
        };

    public static string ToButtonSizeClass(this Size size) =>
        size switch
        {
            Size.ExtraSmall => "btn-xs",
            Size.Small => "btn-sm",
            Size.Medium => "btn-md",
            Size.Large => "btn-lg",
            Size.ExtraLarge => "btn-xl",
            _ => ""
        };

    public static string ToButtonTagName(this ButtonType buttonType) =>
        buttonType switch
        {
            ButtonType.Link => "a",
            _ => "button"
        };

    public static string ToButtonTypeString(this ButtonType buttonType) =>
        buttonType switch
        {
            ButtonType.Button => "button",
            ButtonType.Submit => "submit",
            ButtonType.Reset => "reset",
            _ => ""
        };

    public static string ToCalloutTypeClass(this CalloutType type) =>
        type switch
        {
            CalloutType.Default => "",
            CalloutType.Danger => $"bb-callout-danger",
            CalloutType.Warning => $"bb-callout-warning",
            CalloutType.Info => $"bb-callout-info",
            CalloutType.Tip or CalloutType.Success => $"bb-callout-success",
            _ => ""
        };

    public static string ToCardColorClass(this CardColor color) =>
        color switch
        {
            CardColor.Primary => "text-bg-primary",
            CardColor.Secondary => "text-bg-secondary",
            CardColor.Success => "text-bg-success",
            CardColor.Danger => "text-bg-danger",
            CardColor.Warning => "text-bg-warning",
            CardColor.Info => "text-bg-info",
            CardColor.Light => "text-bg-light",
            CardColor.Dark => "text-bg-dark",
            _ => ""
        };

    public static string ToCssString(this Unit value) =>
        value switch
        {
            Unit.Em => "em",
            Unit.Percentage => "%",
            Unit.Pt => "pt",
            Unit.Px => "px",
            Unit.Rem => "rem",
            Unit.Vh => "vh",
            Unit.VMax => "vmax",
            Unit.VMin => "vmin",
            Unit.Vw => "vw",
            _ => string.Empty
        };

    public static string ToDialogSizeClass(this DialogSize size) =>
        size switch
        {
            DialogSize.Regular => "",
            DialogSize.Small => "modal-sm",
            DialogSize.Large => "modal-lg",
            DialogSize.ExtraLarge => "modal-xl",
            _ => ""
        };

    public static string ToDropdownDirectionClass(this DropdownDirection direction) =>
        direction switch
        {
            DropdownDirection.Dropdown => "dropdown",
            DropdownDirection.DropdownCentered => "dropdown dropdown-center",
            DropdownDirection.Dropend => "dropend",
            DropdownDirection.Dropup => "dropup",
            DropdownDirection.DropupCentered => "dropup dropup-center",
            DropdownDirection.Dropstart => "dropstart",
            _ => ""
        };

    public static string ToDropdownMenuPositionClass(this DropdownMenuPosition position) =>
        position switch
        {
            DropdownMenuPosition.Start => "dropdown-menu-start",
            DropdownMenuPosition.End => "dropdown-menu-end",
            _ => ""
        };

    public static string ToHeadingSizeClass(this HeadingSize headingSize) =>
        headingSize switch
        {
            HeadingSize.H1 => "h1",
            HeadingSize.H2 => "h2",
            HeadingSize.H3 => "h3",
            HeadingSize.H4 => "h4",
            HeadingSize.H5 => "h5",
            HeadingSize.H6 => "h6",
            _ => ""
        };

    public static string ToIconColorClass(this IconColor color) =>
        color switch
        {
            IconColor.Primary => "text-primary",
            IconColor.Secondary => "text-secondary",
            IconColor.Success => "text-success",
            IconColor.Danger => "text-danger",
            IconColor.Warning => "text-warning",
            IconColor.Info => "text-info",
            IconColor.Light => "text-light",
            IconColor.Dark => "text-dark",
            IconColor.Body => "text-body",
            IconColor.Muted => "text-muted",
            IconColor.White => "text-white",
            _ => ""
        };

    public static string ToModalFullscreenClass(this ModalFullscreen fullscreen) =>
        fullscreen switch
        {
            ModalFullscreen.Disabled => "",
            ModalFullscreen.Always => "modal-fullscreen",
            ModalFullscreen.SmallDown => "modal-fullscreen-sm-down",
            ModalFullscreen.MediumDown => "modal-fullscreen-md-down",
            ModalFullscreen.LargeDown => "modal-fullscreen-lg-down",
            ModalFullscreen.ExtraLargeDown => "modal-fullscreen-xl-down",
            ModalFullscreen.ExtraExtraLargeDown => "modal-fullscreen-xxl-down",
            _ => ""
        };

    public static string ToModalHeaderColorClass(this ModalType modalType) =>
        modalType switch
        {
            ModalType.Primary => "text-bg-primary border-bottom border-primary",
            ModalType.Secondary => "text-bg-secondary border-bottom border-secondary",
            ModalType.Success => "text-bg-success border-bottom border-success",
            ModalType.Danger => "text-bg-danger border-bottom border-danger",
            ModalType.Warning => "text-bg-warning border-bottom border-warning",
            ModalType.Info => "text-bg-info border-bottom border-info",
            ModalType.Light => "text-bg-light border-bottom",
            ModalType.Dark => "text-bg-dark border-bottom border-dark",
            _ => ""
        };

    public static string ToModalSizeClass(this ModalSize size) =>
        size switch
        {
            ModalSize.Regular => "",
            ModalSize.Small => "modal-sm",
            ModalSize.Large => "modal-lg",
            ModalSize.ExtraLarge => "modal-xl",
            _ => ""
        };

    public static string ToOffcanvasPlacementClass(this Placement placement) =>
        placement switch
        {
            Placement.Start => "offcanvas-start",
            Placement.End => "offcanvas-end",
            Placement.Top => "offcanvas-top",
            _ => "offcanvas-bottom"
        };

    public static string ToOffcanvasSizeClass(this OffcanvasSize size) =>
        size switch
        {
            OffcanvasSize.Regular => "",
            OffcanvasSize.Small => "bb-offcanvas-sm",
            OffcanvasSize.Large => "bb-offcanvas-lg",
            _ => ""
        };

    public static string ToPaginationAlignmentClass(this Alignment alignment) =>
        alignment switch
        {
            Alignment.Start => "justify-content-start",
            Alignment.Center => "justify-content-center",
            Alignment.End => "justify-content-end",
            _ => ""
        };

    public static string ToPaginationSizeClass(this PaginationSize size) =>
        size switch
        {
            PaginationSize.Small => "pagination-sm",
            PaginationSize.Large => "pagination-lg",
            _ => ""
        };

    public static string ToPlaceholderAnimationClass(this PlaceholderAnimation animation) =>
        animation switch
        {
            PlaceholderAnimation.Glow => "placeholder-glow",
            PlaceholderAnimation.Wave => "placeholder-wave",
            _ => ""
        };

    public static string ToPlaceholderColorClass(this PlaceholderColor color) =>
        color switch
        {
            PlaceholderColor.Primary => "bg-primary",
            PlaceholderColor.Secondary => "bg-secondary",
            PlaceholderColor.Success => "bg-success",
            PlaceholderColor.Danger => "bg-danger",
            PlaceholderColor.Warning => "bg-warning",
            PlaceholderColor.Info => "bg-info",
            PlaceholderColor.Light => "bg-light",
            PlaceholderColor.Dark => "bg-dark",
            _ => ""
        };

    public static string ToPlaceholderSizeClass(this PlaceholderSize size) =>
        size switch
        {
            PlaceholderSize.ExtraSmall => "placeholder-xs",
            PlaceholderSize.Small => "placeholder-sm",
            PlaceholderSize.Large => "placeholder-lg",
            _ => ""
        };

    public static string ToPlaceholderWidthClass(this PlaceholderWidth width) =>
        width switch
        {
            PlaceholderWidth.Col1 => "col-1",
            PlaceholderWidth.Col2 => "col-2",
            PlaceholderWidth.Col3 => "col-3",
            PlaceholderWidth.Col4 => "col-4",
            PlaceholderWidth.Col5 => "col-5",
            PlaceholderWidth.Col6 => "col-6",
            PlaceholderWidth.Col7 => "col-7",
            PlaceholderWidth.Col8 => "col-8",
            PlaceholderWidth.Col9 => "col-9",
            PlaceholderWidth.Col10 => "col-10",
            PlaceholderWidth.Col11 => "col-11",
            PlaceholderWidth.Col12 => "col-12",
            _ => ""
        };

    public static string ToPositionClass(this Position position) =>
        position switch
        {
            Position.Static => BootstrapClass.PositionAbsolute,
            Position.Relative => BootstrapClass.PositionRelative,
            Position.Absolute => BootstrapClass.PositionAbsolute,
            Position.Fixed => BootstrapClass.PositionFixed,
            Position.Sticky => BootstrapClass.PositionSticky,
            _ => ""
        };

    public static string ToProgressColorClass(this ProgressColor color) =>
        color switch
        {
            ProgressColor.Primary => "bg-primary",
            ProgressColor.Secondary => "bg-secondary",
            ProgressColor.Success => "bg-success",
            ProgressColor.Danger => "bg-danger",
            ProgressColor.Warning => "bg-warning",
            ProgressColor.Info => "bg-info",
            ProgressColor.Dark => "bg-dark",
            _ => ""
        };

    public static string ToSizeClass(this Size size) =>
        size switch
        {
            Size.ExtraSmall => "xs",
            Size.Small => "sm",
            Size.Medium => "md",
            Size.Large => "lg",
            Size.ExtraLarge => "xl",
            _ => ""
        };

    public static object ToSortableListPullMode(this SortableListPullMode mode) =>
        mode switch
        {
            SortableListPullMode.True => true,
            SortableListPullMode.False => false,
            SortableListPullMode.Clone => "clone",
            //SortableListPullMode.Array => "array"
        };

    public static object ToSortableListPutMode(this SortableListPutMode mode) =>
        mode switch
        {
            SortableListPutMode.True => true,
            SortableListPutMode.False => false,
            //SortableListPullMode.Array => "array"
        };

    public static string ToSpinnerColorClass(this SpinnerColor color) =>
        color switch
        {
            SpinnerColor.Primary => "text-primary",
            SpinnerColor.Secondary => "text-secondary",
            SpinnerColor.Success => "text-success",
            SpinnerColor.Danger => "text-danger",
            SpinnerColor.Warning => "text-warning",
            SpinnerColor.Info => "text-info",
            SpinnerColor.Light => "text-light",
            SpinnerColor.Dark => "text-dark",
            _ => ""
        };

    public static string ToSpinnerSizeClass(this SpinnerSize size) =>
        size switch
        {
            SpinnerSize.Small => "sm",
            SpinnerSize.Medium => "md",
            SpinnerSize.Large => "lg",
            SpinnerSize.ExtraLarge => "xl",
            _ => "md"
        };

    public static string ToSpinnerTypeClass(this SpinnerType type) =>
        type switch
        {
            SpinnerType.Border => "spinner-border",
            SpinnerType.Grow => "spinner-grow",
            SpinnerType.Dots => "spinner-dots",
            _ => "spinner-border"
        };

    public static string ToTargetString(this Target target) =>
        target switch
        {
            Target.Blank => "_blank",
            Target.Parent => "_parent",
            Target.Top => "_top",
            Target.Self => "_self",
            _ => ""
        };

    public static string ToTextAlignmentClass(this Alignment alignment) =>
        alignment switch
        {
            BlazorBootstrap.Alignment.Start => "text-start",
            BlazorBootstrap.Alignment.Center => "text-center",
            BlazorBootstrap.Alignment.End => "text-end",
            _ => ""
        };

    public static string ToTextColorClass(this TextColor color) =>
        color switch
        {
            TextColor.Primary => "text-primary",
            TextColor.Secondary => "text-secondary",
            TextColor.Success => "text-success",
            TextColor.Danger => "text-danger",
            TextColor.Warning => "text-warning",
            TextColor.Info => "text-info",
            TextColor.Light => "text-light",
            TextColor.Dark => "text-dark",
            TextColor.Body => "text-body",
            TextColor.Muted => "text-muted",
            TextColor.White => "text-white",
            _ => ""
        };

    public static string? ToTooltipColorClass(this TooltipColor color) =>
        color switch
        {
            TooltipColor.Primary => "bb-tooltip-primary",
            TooltipColor.Secondary => "bb-tooltip-tooltip-secondary",
            TooltipColor.Success => "bb-tooltip-success",
            TooltipColor.Danger => "bb-tooltip-danger",
            TooltipColor.Warning => "bb-tooltip-warning",
            TooltipColor.Info => "bb-tooltip-info",
            TooltipColor.Light => "bb-tooltip-light",
            TooltipColor.Dark => "bb-tooltip-dark",
            _ => null
        };

    public static string ToTooltipPlacementName(this TooltipPlacement tooltipPlacement) =>
        tooltipPlacement switch
        {
            TooltipPlacement.Auto => "auto",
            TooltipPlacement.Right => "right",
            TooltipPlacement.Bottom => "bottom",
            TooltipPlacement.Left => "left",
            _ => "top"
        };

    public static string ToToastBackgroundColorClass(this ToastType toastType) =>
        toastType switch
        {
            ToastType.Primary => "bg-primary",
            ToastType.Secondary => "bg-secondary",
            ToastType.Success => "bg-success",
            ToastType.Danger => "bg-danger",
            ToastType.Warning => "bg-warning",
            ToastType.Info => "bg-info",
            ToastType.Light => "bg-light",
            ToastType.Dark => "bg-dark",
            _ => ""
        };

    public static string ToToastsPlacementClass(this ToastsPlacement toastsPlacement) =>
        toastsPlacement switch
        {
            ToastsPlacement.TopLeft => "top-0 start-0",
            ToastsPlacement.TopCenter => "top-0 start-50 translate-middle-x",
            ToastsPlacement.TopRight => "top-0 end-0",
            ToastsPlacement.MiddleLeft => "top-50 start-0 translate-middle-y",
            ToastsPlacement.MiddleCenter => "top-50 start-50 translate-middle",
            ToastsPlacement.MiddleRight => "top-50 end-0 translate-middle-y",
            ToastsPlacement.BottomLeft => "bottom-0 start-0",
            ToastsPlacement.BottomCenter => "bottom-0 start-50 translate-middle-x",
            ToastsPlacement.BottomRight => "bottom-0 end-0",
            _ => "top-0 end-0" // default: Top right
        };

    public static string ToToastTextColorClass(this ToastType toastType) =>
        toastType switch
        {
            ToastType.Primary
                or ToastType.Secondary
                or ToastType.Success
                or ToastType.Danger
                or ToastType.Dark => "text-white",
            ToastType.Warning
                or ToastType.Info
                or ToastType.Light => "text-dark",
            _ => ""
        };

    #endregion
}