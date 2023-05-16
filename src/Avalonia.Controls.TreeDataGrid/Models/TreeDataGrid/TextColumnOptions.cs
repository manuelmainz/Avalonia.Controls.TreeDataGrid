﻿using Avalonia.Media;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    /// <summary>
    /// Holds less commonly-used options for a <see cref="TextColumn{TModel, TValue}"/>.
    /// </summary>
    /// <typeparam name="TModel">The model type.</typeparam>
    public class TextColumnOptions<TModel> : ColumnOptions<TModel>, ITextCellOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the column takes part in text searches.
        /// </summary>
        public bool IsTextSearchEnabled { get; set; }

        /// <summary>
        /// Gets or sets the text trimming mode for the cells in the column.
        /// </summary>
        public TextTrimming TextTrimming { get; set; } = TextTrimming.CharacterEllipsis;
    }
}
