import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import InputLabel from '@material-ui/core/InputLabel';
import FormHelperText from '@material-ui/core/FormHelperText';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import NativeSelect from '@material-ui/core/NativeSelect';

const useStyles = makeStyles((theme) => ({
  formControl: {
    margin: theme.spacing(1),
    minWidth: 120,
  },
  selectEmpty: {
    marginTop: theme.spacing(2),
  },
}));

export default function SelectComponents(props) {
  const classes = useStyles();
  return (
    <div>

      <FormControl variant="filled" className={classes.formControl}>
        <InputLabel htmlFor="filled-age-native-simple">Category</InputLabel>
        <Select
          native
          onChange={props.handleCategoryChange}
          inputProps={{
            name: 'category',
            id: 'filled-age-native-simple',
          }}
        >
          <option aria-label="None" value="" />
          <option value="veshje">Veshje</option>
          <option value="mbathje">Mbathje</option>
          <option value="sportive">Sportive</option>
        </Select>
      </FormControl>
    </div>
  );
}